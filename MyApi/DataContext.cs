using MyApi.Entities;
using System.Net.NetworkInformation;

namespace MyApi
{
    public class DataContext
    {
        public List<Meeting> meeting { get; set; }
        public List<Castomer> castomers { get; set; }
        public List<TaxAdvisor> taxadvisors { get; set; }
        public DataContext()
        {

            meeting = new List<Meeting> {new Meeting{
                 IDmeet =0,
                Date = "09/07/23",
                Hour = "23:00",
                Durationofmeeting1 = 45,
                CastomerId = 12,
                TaxAdvisorId = 9,
                }

             };

            castomers = new List<Castomer> {new Castomer{

                  Status=true,
                   Id=998767908,
                  Name="ruth",
                   Age=56

                 }

             };

            taxadvisors = new List<TaxAdvisor>{new TaxAdvisor{

                    Id = 998767908,
                    Name = "ruth",
                    Age = 56,
                    Status=true,

                }
             };


        }
    }
}
