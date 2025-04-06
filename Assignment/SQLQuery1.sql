INSERT INTO Users (email_id, name, password, roles, phone_number)
VALUES
('alice.wonder@example.com', 'Alice Wonder', 'A1i$cW@nD3r!', 'Customer', '0928347561'),
('bob.builder@example.com', 'Bob Builder', 'Bui1d#4R_!', 'Customer', '0482957362'),
('charlie.brown@example.com', 'Charlie Brown', 'Ch@rL13&Bro$', 'Customer', '0547829361'),
('diana.ross@example.com', 'Diana Ross', 'D1@nARo$$78!', 'Customer', '0103847562'),
('edward.snow@example.com', 'Edward Snow', 'Edw@rd_S#nO!', 'Customer', '0392847561'),
('fiona.apple@example.com', 'Fiona Apple', 'Fi0n@App!3_56$', 'Customer', '0658923467'),
('george.king@example.com', 'George King', 'Georg3K1ng@!', 'Customer', '0768234598'),
('hannah.montana@example.com', 'Hannah Montana', 'HanM@nt78_!', 'Customer', '0839456271'),
('ian.wright@example.com', 'Ian Wright', 'Wr1ghtIan@23!', 'Customer', '0912837564'),
('julia.roberts@example.com', 'Julia Roberts', 'Ju1i@Rob#R45!', 'Customer', '0273847596');

SELECT * FROM Requests;

INSERT INTO requests (request_id, email_id, type_of_event, special_requests, number_of_people, approval, message_from_coordinator, start_date, start_time, end_time, additional_additions)
VALUES
(1, 'alice.wonder@example.com', 'Wedding', 'Vegan catering required', '150', 'Approved', 'All set for the big day!', '2025-05-15', '15:00', '22:00', 'Decor with floral arrangements'),
(2, 'bob.builder@example.com', 'Corporate Meeting', 'Projector and whiteboard needed', '20', 'Pending', 'Awaiting client confirmation', '2025-04-25', '09:00', '12:00', 'Coffee and snacks for all participants'),
(3, 'charlie.brown@example.com', 'Birthday Party', 'Theme: Superheroes', '50', 'Approved', 'Confirmed with the decorations vendor', '2025-07-10', '18:00', '23:00', 'Special cake design'),
(4, 'diana.ross@example.com', 'Music Concert', 'Stage lighting and sound check required', '300', 'Rejected', 'Insufficient budget approval', '2025-06-01', '19:00', '22:00', 'Backstage crew support'),
(5, 'edward.snow@example.com', 'Art Exhibition', 'Frames for all paintings', '100', 'Approved', 'Art space reserved', '2025-05-20', '10:00', '17:00', 'Additional security'),
(6, 'fiona.apple@example.com', 'Workshop', 'Tables and chairs for 30 people', '30', 'Pending', 'Coordinator will confirm layout', '2025-04-20', '13:00', '16:00', 'Laptop charging ports'),
(7, 'george.king@example.com', 'Conference', 'Wi-Fi for all attendees', '200', 'Approved', 'Technical setup is complete', '2025-05-05', '08:00', '17:00', 'Simultaneous translation equipment'),
(8, 'hannah.montana@example.com', 'Fashion Show', 'Runway lights and makeup artists', '150', 'Pending', 'Organizer reviewing requirements', '2025-08-01', '16:00', '21:00', 'Temporary dressing rooms'),
(9, 'ian.wright@example.com', 'Charity Gala', 'Seating arrangements for VIPs', '250', 'Approved', 'Catering finalized', '2025-09-10', '18:30', '23:30', 'Stage backdrop with organization logo'),
(10, 'julia.roberts@example.com', 'Film Screening', 'HD projector and surround sound', '75', 'Approved', 'Venue reserved and equipment set', '2025-06-15', '19:30', '22:00', 'Exclusive invitations');