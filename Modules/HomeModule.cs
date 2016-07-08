using Nancy;
using System;
using System.Collections.Generic;

namespace RepeatCounter.Objects
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };
            Post["/result"] = _ => {
                RepeatCounter newCounter = new RepeatCounter();
                var NumberOfWords = newCounter.CountRepeats(Request.Form["user-sentence"], Request.Form["user-word"]);
                return View["result.cshtml", NumberOfWords];
            };
        }
    }
}
