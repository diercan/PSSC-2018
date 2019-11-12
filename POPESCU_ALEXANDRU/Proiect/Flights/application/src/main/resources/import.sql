INSERT INTO `hph`.`user` (`id`, `email`, `first_name`, `last_name`, `password`, `role`, `username`) VALUES (1, 'asd', 'asd@gmail.com', 'asd', 'asd', 'CUSTOMER', 'asd');
INSERT INTO `hph`.`user` (`id`, `email`, `first_name`, `last_name`, `password`, `role`, `username`) VALUES (2, 'abc', 'abc@gmail.com', 'abc', 'abc', 'CUSTOMER', 'abc');
INSERT INTO `hph`.`user` (`id`, `email`, `first_name`, `last_name`, `password`, `role`, `username`) VALUES (3, 'admin', 'admin@gmail.com', 'admin', 'admin', 'ADMIN', 'admin');

INSERT INTO `hph`.`airplane` (`id`, `available_seats`) VALUES (1, '5');
INSERT INTO `hph`.`flight` (`id`,`from_city`, `sent_emails`, `time`, `to_city`, `airplane_id`, `seats_taken`, `all_emails_sent`) VALUES (1, 'Timisoara', '0', '2019-01-06 19:27:10', 'Bucuresti', '1', 1, true);
INSERT INTO `hph`.`flight` (`id`,`from_city`, `sent_emails`, `time`, `to_city`, `airplane_id`, `seats_taken`, `all_emails_sent`) VALUES (2, 'Bucuresti', '0', '2019-01-06 19:27:10', 'Timisoara', '1', 1, true);
INSERT INTO `hph`.`flight` (`id`,`from_city`, `sent_emails`, `time`, `to_city`, `airplane_id`, `seats_taken`, `all_emails_sent`) VALUES (3, 'Cluj Napoca', '0', '2019-01-06 19:27:10', 'Sibiu', '1', 0, true);
INSERT INTO `hph`.`flight` (`id`,`from_city`, `sent_emails`, `time`, `to_city`, `airplane_id`, `seats_taken`, `all_emails_sent`) VALUES (4, 'Sibiu', '0', '2019-01-06 19:27:10', 'Cluj Napoca', '1', 0, true);
INSERT INTO `hph`.`flight` (`id`,`from_city`, `sent_emails`, `time`, `to_city`, `airplane_id`, `seats_taken`, `all_emails_sent`) VALUES (5, 'Timisoara', '0', '2019-05-29 16:00:10', 'Prague', '1', 0, true);

INSERT INTO `hph`.`booking` (`id`, `flight_id`, `user_id`) VALUES (1, 1, 1);
INSERT INTO `hph`.`booking` (`id`, `flight_id`, `user_id`) VALUES (2, 1, 2);