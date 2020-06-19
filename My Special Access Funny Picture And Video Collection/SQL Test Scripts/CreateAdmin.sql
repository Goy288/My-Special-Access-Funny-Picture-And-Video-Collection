INSERT INTO [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], 
								 [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber],
								 [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
	   VALUES (N'34f6cf97-22bf-4c05-8748-d6eed8ea4cec', 0, N'ee5eb38f-99ea-48b9-9381-e910d530b11d',
			   N'admin@fakedomain.com', 1, 1, NULL, N'ADMIN@FAKEDOMAIN.COM', N'ADMINISTRATOR',
-- PASSWORD:"ThisIsTheAdminPassword#1234567890" (I don't know how to convert the password into a compatible hash in the SQL script, so here's a premade one) --
			   N'AQAAAAEAACcQAAAAEPoF8yXiHIhYGdlI5R/ZtEghupCxVXKVcEnXp+mhbiF4RhRm44SPF7shNy+IPc/SKA==', 
			   N'+12345678910', 1, N'c0cf9fc0-8205-4fe0-86ab-3c679eaa64ec', 0, N'administrator')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId])
	   VALUES (N'34f6cf97-22bf-4c05-8748-d6eed8ea4cec', N'841f4657-6e6d-4e4a-be8c-2af8d54b04b2')