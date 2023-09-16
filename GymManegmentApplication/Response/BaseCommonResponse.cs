using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManegmentApplication.Response
{
    public class BaseCommonResponse
    {
        public int Id { get; set; }
        public bool IsSuccess { get; set; }=true;
        public string Message { get; set; } = "";
        public List<string> Errors { get; set; } = new List<string>();
    }
}
