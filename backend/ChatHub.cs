
using Microsoft.AspNetCore.SignalR;
public class ChatHub:Hub{
 public async Task Send(string user,string msg){
  await Clients.All.SendAsync("Receive",user,msg);
 }
}
