using System.Collections.Generic;
using System;
using System.Globalization;
using System.Text.Json.Serialization;

namespace take_test.API.Domain.Model
{
    public class Carousel
    {

            public string  itemType {get; set;}
            public List<Item> items {get; set;}

    }
    public class Item{
       public Header header {get; set;}
    } 
    

    public class Header {
        public string type {get; set;}
        public HeaderValue value {get; set;}
    }

    public class HeaderValue{
        public string title {get; set;}
        public string text {get; set;}

        public string type {get; set;}
        public string uri {get; set;}

    }
}
