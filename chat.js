const express = require('express')
const app = express()
const fs = require('fs');

app.set('view engine', 'ejs')

app.use(express.static('public'))

app.get('/', (req, res) => {
    res.render('index')
})
server = app.listen(4201)

const io = require("socket.io")(server)

console.log('Start Aplication');
io.on('connection', (socket) => {
    console.log('New user connected');
    logDataFcn("new user conected");
    fs.readFile('chatApp.json', (err, data) => {
        if (err) throw err;
        let mess = JSON.parse(data);
        io.sockets.emit('last_message', { message: mess.users });
    });

    socket.on('open', (data) => {
        //console.log(data)
    })

    socket.on('new_message', (data) => {
        // console.log(data);
        let mess = { message: data.message, username: data.username }
        io.sockets.emit('new_message', { message: data.message, username: data.username });
        var fs = require('fs')
        fs.readFile('./chatApp.json', 'utf-8', function (err, dataRead) {
            if (err) throw err
            var arrayOfObjects = JSON.parse(dataRead)
            arrayOfObjects.users.push({
                message: data.message,
                username: data.username
            })
            fs.writeFile('./chatApp.json', JSON.stringify(arrayOfObjects), 'utf-8', function (err) {
                if (err) throw err
                console.log('message write')
            })
        })
    })


    socket.on('createUser', (data) => {
        // console.log(data);
        console.log(data);
        var fs = require('fs')
        var flagExistUser = false;
        fs.readFile('./users.json', 'utf-8', function (err, dataRead) {
            if (err) throw err
            let logData = JSON.parse(dataRead);
            for (var val in logData.users) {
                if (logData.users[val].username == data.user.username) {
                    flagExistUser = true;
                }
                if (logData.users[val].username != data.user.username && flagExistUser == false && val == logData.users.length - 1) {
                    var arrayOfObjects = JSON.parse(dataRead)
                    arrayOfObjects.users.push({
                        name: data.user.name,
                        username: data.user.username,
                        telNumber: data.user.telNumber,
                        email: data.user.email,
                        password: data.user.password,
                        cPassword: data.user.cPassword,
                    });
                    fs.writeFile('./users.json', JSON.stringify(arrayOfObjects), 'utf-8', function (err) {
                        if (err) throw err
                        console.log('add new user')
                        let text = "add user:" + data.user.username;
                        logDataFcn(text);
                        io.sockets.emit('createUserConfirm', { message: data.user });
                    })
                }
                if (!(logData.users[val].username != data.user.username && flagExistUser == false) && val == logData.users.length - 1) {
                    console.log('this user exist')
                    let text = "user:" + data.user.username + "  exist";
                    logDataFcn(text);
                    io.sockets.emit('userExist', { message: data.user.username });
                }
            }
        })
    })


    socket.on('login', (data) => {
        
        fs.readFile('users.json', (err, data_json) => {
            
            var flagExistUser = false;
            if (err) throw err;
            let logData = JSON.parse(data_json);
            for (var val in logData.users) {
                if (logData.users[val].username == data.user && logData.users[val].password == data.password) {
                    io.sockets.emit('loginAccept', { message: data.user });
                    flagExistUser = true;
                    console.log("login");
                    let text = "login:" + data.user;
                    logDataFcn(text);
                }
                if ((logData.users[val].username != data.user || logData.users[val].password != data.password) && val == logData.users.length - 1 && flagExistUser == false) {
                    io.sockets.emit('loginDenied', { message: data.user });
                    console.log("login failed");
                    let text = "login failed for:" + data.user;
                    logDataFcn(text);
                }
            }

        });
    });
    socket.on('logout', (data) => {
        io.sockets.emit('logoutAccept', { message: data.user });
        console.log("logout");
        let text = "logout " + data.user;
        logDataFcn(text);

    });

})

var logDataFcn = async (data) => {
    var fs = require('fs')
    fs.readFile('./log.json', 'utf-8', function (err, dataRead) {
        if (err) throw err
        var arrayOfObjects = JSON.parse(dataRead)
        arrayOfObjects.log.push({
            log: data,
        })
        fs.writeFile('./log.json', JSON.stringify(arrayOfObjects), 'utf-8', function (err) {
            if (err) throw err
        })
    })
}