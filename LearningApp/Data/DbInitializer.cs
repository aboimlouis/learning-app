using LearningApp.Domain.Models;

namespace LearningApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(Context context)
        {
            if (context.Users.Any())
            {
                return;
            }

            var users = new UserModel[]
            {
                new UserModel{ Name = "Test1", UserName = "TestUserName1", Password = "TempPassword" },
                new UserModel{ Name = "Test2", UserName = "TestUserName2", Password = "TempPassword" },
                new UserModel{ Name = "Test3", UserName = "TestUserName3", Password = "TempPassword" },
                new UserModel{ Name = "Test4", UserName = "TestUserName4", Password = "TempPassword" }
            };

            context.Users.AddRange(users);
            context.SaveChanges();

            var characters = new CharacterModel[]
            {
                new CharacterModel{ Name = "Test1", UserID = 1, Level = 0 },
                new CharacterModel{ Name = "Test2", UserID = 1, Level = 5 },
                new CharacterModel{ Name = "Test3", UserID = 2, Level = 10 },
                new CharacterModel{ Name = "Test4", UserID = 3, Level = 10 }
            };

            context.Charaters.AddRange(characters);
            context.SaveChanges();
        }
    }
}
