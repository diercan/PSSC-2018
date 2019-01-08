import { Injectable } from '@angular/core';
import * as crypto from "crypto-browserify";

@Injectable({
  providedIn: 'root'
})
export class CryptoService {
  private readonly ALGORITHM: string = "AES-256-CBC";
  private readonly KEY: any =  "8479768f48481eeb9c8304ce0a58481eeb9c8304ce0a5e3cb5e3cb58479768f4";
  constructor() {
    var input = "testing";

    var encrypted = this.encrypt(input);
    console.info('encrypted:', encrypted);
    // var decryped = this.decrypt(encrypted);
    // console.info('decryped:', decryped);

  }

  public encrypt(input) {

    try {
      let data = new Buffer(input).toString('binary');
      let iv = crypto.randomBytes(16);
      let key = new Buffer(this.KEY, "hex");
      let cipher = crypto.createCipheriv(this.ALGORITHM, key, iv);
      let encrypted;
      encrypted = cipher.update(data, 'utf8', 'binary') + cipher.final('binary');
      let encoded = new Buffer(iv, 'binary').toString('hex') + "$" + new Buffer(encrypted, 'binary').toString('hex'); // for php explode
      // let encoded = new Buffer(iv, 'binary').toString('hex') +  new Buffer(encrypted, 'binary').toString('hex'); // for js
      return encoded;
    } catch (ex) {
      console.error(ex);
    }
  };

  public decrypt(encoded) {

    let combined = new Buffer(encoded, 'hex');
    let key = new Buffer(this.KEY, "hex");
    let iv = new Buffer(16);
    combined.copy(iv, 0, 0, 16);
    let edata = combined.slice(16).toString('binary');
    let decipher = crypto.createDecipheriv(this.ALGORITHM, key, iv);
    let plaintext;

    plaintext = (decipher.update(edata, 'binary', 'utf8') + decipher.final('utf8'));
    return plaintext;


  };
}
