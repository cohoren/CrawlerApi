using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CrawlerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrawlerController : ControllerBase
    {
        // GET api/values
        [HttpGet("{url}/{matchWord}")]
        //https://localhost:44358/api/crawler/www.google.com/hello,google?depth=3
        //https://localhost:44358/api/crawler/rrr?matchWord=5&matchword=7&depth=8
        //public async Task<ActionResult<IEnumerable<string>>> ExtractInfoFromWebsiteAsync(string url, [FromQuery]string[] matchWord, int depth)
        public async Task<ActionResult<string>> ExtractInfoFromWebsiteAsync(string url, [FromQuery]string[] matchWord, int depth)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://www.aaa.com/International/");
            var pageContents = await response.Content.ReadAsStringAsync();
            return pageContents;
            //Console.WriteLine(pageContents);
            //Console.ReadLine();

            //return new string[] {"koko", "loko"};
        }

       // GET api/values
       //[HttpGet]
       // public ActionResult<IEnumerable<string>> Get()
       // {
       //     return new string[] { "value1", "value2" };
       // }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
