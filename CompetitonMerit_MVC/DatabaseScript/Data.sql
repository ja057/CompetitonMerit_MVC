SET IDENTITY_INSERT [dbo].[Subject] ON
INSERT INTO [dbo].[Subject] ([Id], [Subject_Name], [Subject_description], [Subject_language]) VALUES (1, N'Mathematics', N'The subject include questions from Basic level to Advance level. And will also have problem solving tasks. ', N'English')
INSERT INTO [dbo].[Subject] ([Id], [Subject_Name], [Subject_description], [Subject_language]) VALUES (2, N'English', N'The Tests included many literatures especially of Shakespeare''s Poem and Play. And also had advance level English Grammar. ', N'Engish')
INSERT INTO [dbo].[Subject] ([Id], [Subject_Name], [Subject_description], [Subject_language]) VALUES (3, N'Intermediate French', N'Subject Contained beginner and high level exam with some grammar and spell check questions.', N'French and English')
INSERT INTO [dbo].[Subject] ([Id], [Subject_Name], [Subject_description], [Subject_language]) VALUES (4, N'Biology ', N'The Test Basically included Multiple choice question and some diagram. The content is based on full syllabus of the subject. ', N'English')
INSERT INTO [dbo].[Subject] ([Id], [Subject_Name], [Subject_description], [Subject_language]) VALUES (5, N'Chemistry ', N'The questionnaire of the test mostly contained MCQs and full length Paragraph Answers. The syllabus was about thermodynamics and chemistry in daily life. It also had some chemical equations in paper.', N'English')
INSERT INTO [dbo].[Subject] ([Id], [Subject_Name], [Subject_description], [Subject_language]) VALUES (6, N'Physics ', N'Subject''s test is all about the fundamentals of physics but main focus was on the theory of relativity and there would be some numerical as well.', N'English')
INSERT INTO [dbo].[Subject] ([Id], [Subject_Name], [Subject_description], [Subject_language]) VALUES (7, N'G.K Olympiad ', N'This Subject contained General Knowledge of the world and current issue on the world. Student needed to prepare all the knowledge up to date. It contained all the questions in MCQs form.', N'English, French or Hindi')
SET IDENTITY_INSERT [dbo].[Subject] OFF
SET IDENTITY_INSERT [dbo].[School] ON
INSERT INTO [dbo].[School] ([Id], [School_Name], [School_Address], [School_Mobile], [School_Webite]) VALUES (1, N'Botany Downs Secondary College', N'575 Chapel Road, Howick, Auckland 2016', N' 09-273 2310', N'https://www.bdsc.school.nz/')
INSERT INTO [dbo].[School] ([Id], [School_Name], [School_Address], [School_Mobile], [School_Webite]) VALUES (2, N'King''s College', N'Golf Avenue, Otahuhu, Auckland 1640', N' 09-276 0600', N'https://www.kingscollege.school.nz/')
INSERT INTO [dbo].[School] ([Id], [School_Name], [School_Address], [School_Mobile], [School_Webite]) VALUES (3, N'Auckland Grammar School', N'55-87 Mountain Road, Epsom, Auckland 1023', N'09-623 5400', N'https://www.ags.school.nz/')
INSERT INTO [dbo].[School] ([Id], [School_Name], [School_Address], [School_Mobile], [School_Webite]) VALUES (4, N'One Tree Hill College', N' 421-451 Great South Road, Penrose, Auckland 1062', N'09-579 5049', N'https://www.onetreehillcollege.school.nz/')
INSERT INTO [dbo].[School] ([Id], [School_Name], [School_Address], [School_Mobile], [School_Webite]) VALUES (5, N'ACG Senior School', N'66 Lorne Street, Auckland CBD, Auckland 1010', N'09-307 4477', N'https://seniorcollege.acgedu.com/')
INSERT INTO [dbo].[School] ([Id], [School_Name], [School_Address], [School_Mobile], [School_Webite]) VALUES (6, N'St Joseph''s  International School.', N' 456 Great North Road, Auckland 1021', N'09-376 5456', N'https://www.st-josephInternational.school.nz')
SET IDENTITY_INSERT [dbo].[School] OFF
SET IDENTITY_INSERT [dbo].[Student_participate] ON
INSERT INTO [dbo].[Student_participate] ([Id], [Student_Name], [Student_age], [Mobile_Number], [Student_Address], [Father_Name]) VALUES (1, N'David', 20, N'0223009020', N'2/24 Leonard Road, Mount Wellington', N'Om Parkash')
INSERT INTO [dbo].[Student_participate] ([Id], [Student_Name], [Student_age], [Mobile_Number], [Student_Address], [Father_Name]) VALUES (2, N'Manish Kumar', 19, N'022659847', N'4 Milton Road, Papatoetoe', N'Dinesh Kumar')
INSERT INTO [dbo].[Student_participate] ([Id], [Student_Name], [Student_age], [Mobile_Number], [Student_Address], [Father_Name]) VALUES (3, N'Goutam Sharma', 21, N'213344551', N'22 Upland Road, Remuera, Auckland', N'JaganNath Sharma')
INSERT INTO [dbo].[Student_participate] ([Id], [Student_Name], [Student_age], [Mobile_Number], [Student_Address], [Father_Name]) VALUES (4, N'Manpreet Kaur', 19, N'228119211', N'24 Ladies Mile, Ellerslie Auckland 1098  ', N'Sukhwinder Singh')
INSERT INTO [dbo].[Student_participate] ([Id], [Student_Name], [Student_age], [Mobile_Number], [Student_Address], [Father_Name]) VALUES (5, N'Avneet Kaur', 18, N'022017711', N'1 Dedwood Terrace , Ponsonby Auckland 6548', N'Jatinder Singh')
INSERT INTO [dbo].[Student_participate] ([Id], [Student_Name], [Student_age], [Mobile_Number], [Student_Address], [Father_Name]) VALUES (6, N'Hannah Lee', 20, N'0228712347', N'55 Wakefield Street, CBD, Auckland 1245 ', N'John Lee ')
INSERT INTO [dbo].[Student_participate] ([Id], [Student_Name], [Student_age], [Mobile_Number], [Student_Address], [Father_Name]) VALUES (7, N'Dilpreet Singh', 21, N'758423164', N'3 Eldon Road , Mount Eden, Auckland, 2376', N'Simranpreet Singh')
SET IDENTITY_INSERT [dbo].[Student_participate] OFF
SET IDENTITY_INSERT [dbo].[Meritlist] ON
INSERT INTO [dbo].[Meritlist] ([Id], [Student_participateId], [SchoolId], [SubjectId], [Marks]) VALUES (1, 1, 1, 1, 95)
INSERT INTO [dbo].[Meritlist] ([Id], [Student_participateId], [SchoolId], [SubjectId], [Marks]) VALUES (2, 2, 2, 2, 90)
INSERT INTO [dbo].[Meritlist] ([Id], [Student_participateId], [SchoolId], [SubjectId], [Marks]) VALUES (3, 3, 3, 3, 96)
INSERT INTO [dbo].[Meritlist] ([Id], [Student_participateId], [SchoolId], [SubjectId], [Marks]) VALUES (4, 4, 4, 4, 97)
INSERT INTO [dbo].[Meritlist] ([Id], [Student_participateId], [SchoolId], [SubjectId], [Marks]) VALUES (5, 5, 4, 5, 96)
INSERT INTO [dbo].[Meritlist] ([Id], [Student_participateId], [SchoolId], [SubjectId], [Marks]) VALUES (6, 6, 5, 6, 99)
INSERT INTO [dbo].[Meritlist] ([Id], [Student_participateId], [SchoolId], [SubjectId], [Marks]) VALUES (7, 7, 6, 7, 99)
SET IDENTITY_INSERT [dbo].[Meritlist] OFF