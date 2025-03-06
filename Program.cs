using EmailBox;
using static System.Net.WebRequestMethods;

string[] prefixes = { "http://localhost:5000/" };

Server s = new Server(prefixes);
await s.Start();