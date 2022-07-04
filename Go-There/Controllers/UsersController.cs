using Microsoft.AspNetCore.Mvc;

namespace Go_There.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{

  private static List<Models.Users> users = new List<Models.Users>{
new Models.Users{ Id=1, Name="John", Surname="Emili",Adress="203/15 Sokak no:6 daire 12",Email="John@example.com", Password="password",Age=20 },
new Models.Users{ Id=2, Name="Maya", Surname="Stark",Adress="203/15 Sokak no:6 daire 12",Email="John@example.com", Password="password",Age=20 },
        };


    [HttpGet]
    public async Task<ActionResult<List<Models.Users>>> Get()
    {
      
        return Ok(users);
    }


    [HttpPost]
 public async Task<ActionResult<List<Models.Users>>> AddUser(Models.Users user)
    {
      users.Add(user);
        return Ok(users);
    }
    [HttpGet("{id}")]
 public async Task<ActionResult<List<Models.Users>>> GetSpesificUser(int id)
    {
     var userGet=users.Find(h=> h.Id == id);
     if(userGet==null) return BadRequest("User Not Found");
     else return Ok(userGet);
     
    }
[HttpPut]
 public async Task<ActionResult<List<Models.Users>>> Put(Models.Users user)
    {

        var userPut =users.Find(h=> h.Id == user.Id);
     if(userPut==null) return BadRequest("User " + user.Id + " not found");
     
      userPut.Name = user.Name;
      userPut.Email = user.Email;
      userPut.Password = user.Password; 
      userPut.Adress = user.Adress;
      userPut.Age = user.Age;
      userPut.Surname = user.Surname;
    
        return Ok(users);
    }
    [HttpDelete]
    public async Task<ActionResult<List<Models.Users>>> DeleteUser(int id)
    {
     var userDelete=users.Find(h=> h.Id == id);
     if(userDelete==null) return BadRequest("User Not Found");
     else users.Remove(userDelete); return Ok(userDelete);
     
    }
}
