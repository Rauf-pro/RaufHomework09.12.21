USE [EduHomeAPanel]
GO
SET IDENTITY_INSERT [dbo].[Blogs] ON 

INSERT [dbo].[Blogs] ([Id], [BgImage], [Title], [CreatedDate]) VALUES (1, N'banner.jpg', N'Blogs', CAST(N'2021-10-28T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Blogs] OFF
GO
