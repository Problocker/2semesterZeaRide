INSERT INTO [dbo].[Samkorsel] ([samkorselID], [fraDestination], [tilDestination], [bemaerkninger], [dato], [tid], [passager]) VALUES (1, N'Roskilde st. ', N'Roskilde Zealand ', N'Kun tøser med i bilen. ', N'2020-05-15', N'08:00:00', 1)
INSERT INTO [dbo].[Samkorsel] ([samkorselID], [fraDestination], [tilDestination], [bemaerkninger], [dato], [tid], [passager]) VALUES (2, N'Taastrup st. ', N'Roskilde Zealand ', N'Køre som om jeg har stjålet bilen. ', N'2020-07-15', N'08:00:00', 1)

INSERT INTO [dbo].[PersonligeOplysninger] ([email], [kodeord]) VALUES (N'nikolaj@zealand.dk ', N'Kagemand1')
INSERT INTO [dbo].[PersonligeOplysninger] ([email], [kodeord]) VALUES (N'mikkel@zealand.dk ', N'Pengepung1')
INSERT INTO [dbo].[PersonligeOplysninger] ([email], [kodeord]) VALUES (N'marc@zealand.dk ', N'Sodavand1')
INSERT INTO [dbo].[PersonligeOplysninger] ([email], [kodeord]) VALUES (N'martin@zealand.dk ', N'Pokemon1')

INSERT INTO [dbo].[Postnummer] ([postnummer], [by]) VALUES (4000, N'Roskilde')
INSERT INTO [dbo].[Postnummer] ([postnummer], [by]) VALUES (2630, N'Taastrup')
INSERT INTO [dbo].[Postnummer] ([postnummer], [by]) VALUES (4360, N'Kirke Eskilstrup')
INSERT INTO [dbo].[Postnummer] ([postnummer], [by]) VALUES (2640, N'Hedehusene')

INSERT INTO [dbo].[Bruger] ([brugerID], [navn], [efternavn], [bilmodel], [farve], [FK_postnummer], [FK_email]) VALUES (1, N'Nikolaj ', N'Hansen ', N'BMW M5 ', N'Sølvgrå ', 4000, N'nikolaj@zealand.dk')
INSERT INTO [dbo].[Bruger] ([brugerID], [navn], [efternavn], [bilmodel], [farve], [FK_postnummer], [FK_email]) VALUES (2, N'Mikkel ', N'Olsen ', N'Nissan Skyline ', N'Lilla ', 2630, N'mikkel@zealand.dk')
INSERT INTO [dbo].[Bruger] ([brugerID], [navn], [efternavn], [bilmodel], [farve], [FK_postnummer], [FK_email]) VALUES (3, N'Marc ', N'Fordman ', NULL, NULL, 4360, N'marc@zealand.dk')
INSERT INTO [dbo].[Bruger] ([brugerID], [navn], [efternavn], [bilmodel], [farve], [FK_postnummer], [FK_email]) VALUES (4, N'Martin ', N'Pedersen ', NULL, NULL, 2640, N'martin@zealand.dk')

INSERT INTO [dbo].[Samkorsler] ([FK_samkorselID], [FK_brugerID]) VALUES (1, 1)
INSERT INTO [dbo].[Samkorsler] ([FK_samkorselID], [FK_brugerID]) VALUES (2, 2)

