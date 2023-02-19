




using CustomLinq;
using System.Linq;

var users = new List<UserModel>() {

    new UserModel()
    {
        Id = 8,
        FirstName= "Yasin1",
        LastName= "Çoban",
        CreatedDate= DateTime.Now,
        Email =     "cobanyasin1998@gmail.com"
    },
     new UserModel()
    {
        Id = 2,
        FirstName= "Yasin2",
        LastName= "Çoban",
        CreatedDate= DateTime.Now,
        Email =     "cobanyasin1998@hotmail.com"
    },
      new UserModel()
    {
        Id = 1,
        FirstName= "Yasin3",
        LastName= "Çoban",
        CreatedDate= DateTime.Now,
        Email =     "cobanyasin1998@outlook.com"
    },
};
var evenIDUsers = users.CustomWhere_EvenID().CustomToList();

var firstUser = users.CustomFirstOrDefault();
Console.WriteLine(firstUser?.FirstName);

Console.WriteLine(evenIDUsers.Count());


var linQUser = users
    .Where(x => x.Id % 2 == 0)
    .Where(x => x.Email.EndsWith("gmail.com"))
    .ToList();

var CustomLinQUser = users
    .CustomWhere_EvenID()
    .CustomWhere_GmailUsers()
    .CustomToList();


Console.ReadLine();
//users.Where(x => x.FirstName == "Yasin").Select(x => x.FirstName);