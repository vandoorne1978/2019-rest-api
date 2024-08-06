using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace _2019_rest_api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListingsController : ControllerBase
    {
        private readonly ILogger<ListingsController> _logger;

        public ListingsController(ILogger<ListingsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/listings")]
        public IEnumerable<Listing> Get()
        {
            string[] photos = { "Photo1", "Photo2" };
            string[] photos2 = { "Photo1", "Photo2" };
            Listing[] listings = {
                new Listing {
                    Heading = "40' Pacific Trawler 40",
                    Type = "New Listing",
                    Year = "2001",
                    Price = "US$ 174,500",
                    Location = "Lynn, MA",
                    Hull = "Fiberglass",
                    Engine = "",
                    YW ="63629-3671103",
                    Photos = photos,
                    Broker = "Brandon Grigger",
                    Summary = "WAIT N SEA - Is new to the market and ready to take you cruising!  She is powered with a single Yanmar Diesel 350hp w/ 3725 hours, Northern Lights Gen, Updated 2019 - Simrad Electronics Chart Plotter, Radar & Autopilot, Bow Thruster, Espar Heating system and much more. Cruising at a comfortable and economical 8kts with over a 1000 mile range, makes this a great candidate for the Loop or cruising the Coasts!"+
                        "The Pacific Trawler PT40 is well known for its sea keeping & livability.Thinking of Looping ? Then look no further.This loop veteran is a perfect combination of big enough to handle rough weather and small enough to be easily handled."+
                        "Wait N Sea - offers the following features:"+
                        "The single stateroom design allows for a very large and spacious salon.Large windows in the salon let in lots of natural light, visibility & air.Throughout the vessel is a mix of mahogany cabinetry against lite beige surfaces and Brazilian cherry and holly sole."+
                        "The cockpit is an open transom design with removable railings creates a tremendously large space.Owners of these boats rave about this design.This unique design is very advantageous for easy access while boarding the boat. From tender or dock, the open design makes for quick, safe, and efficient loading of guests and provisions."+
                        "Currently on the hard and scheduled to launch in Mid - May.Owner has Fully Commissioned the boat Spring 2020.She will be in her slip ready to show!  Call today to schedule a showing or go to specs to view the full listing."+
                        "More Photos Coming Soon!!"
                },
                new Listing {
                    Heading = "40' Sea Ray 400 Sundancer",
                    Type = "Price just reduced",
                    Year = "1998",
                    Price = "US$ 107,500",
                    Location = "Newburyport, MA",
                    Hull = "Fiberglass",
                    Engine = "Twin diesel",
                    YW ="63629-3492595",
                    Photos = photos2,
                    Broker = "Brandon Grigger",
                    Summary = "AT LAST - is a well cared for 40' Sundancer - Powered by Twin 3116 Cat Diesel with Low Hours -  always been professionally maintained.  The 40' Sundancer has a great layout with - Two Staterooms and Two Heads.AT LAST is ready to cruise and is equipped to do so with AC and Heat, Autopilot, Radar, GPS Chartplotter, Generator, Full canvas enclosure and much more.  Owner is moving up in size and is open to all offers!Call today to schedule a showing or go to specs to view full listing."
                },
                new Listing {
                    Heading = "40' Sea Ray 400 Sundancer",
                    Type = "Price just reduced",
                    Year = "1998",
                    Price = "US$ 107,500",
                    Location = "Newburyport, MA",
                    Hull = "Fiberglass",
                    Engine = "Twin diesel",
                    YW ="63629-3492595",
                    Photos = photos2,
                    Broker = "Brandon Grigger",
                    Summary = "AT LAST - is a well cared for 40' Sundancer - Powered by Twin 3116 Cat Diesel with Low Hours -  always been professionally maintained.  The 40' Sundancer has a great layout with - Two Staterooms and Two Heads.AT LAST is ready to cruise and is equipped to do so with AC and Heat, Autopilot, Radar, GPS Chartplotter, Generator, Full canvas enclosure and much more.  Owner is moving up in size and is open to all offers!Call today to schedule a showing or go to specs to view full listing."
                },
                new Listing {
                    Heading = "40' Sea Ray 400 Sundancer",
                    Type = "Price just reduced",
                    Year = "1998",
                    Price = "US$ 107,500",
                    Location = "Newburyport, MA",
                    Hull = "Fiberglass",
                    Engine = "Twin diesel",
                    YW ="63629-3492595",
                    Photos = photos2,
                    Broker = "Brandon Grigger",
                    Summary = "AT LAST - is a well cared for 40' Sundancer - Powered by Twin 3116 Cat Diesel with Low Hours -  always been professionally maintained.  The 40' Sundancer has a great layout with - Two Staterooms and Two Heads.AT LAST is ready to cruise and is equipped to do so with AC and Heat, Autopilot, Radar, GPS Chartplotter, Generator, Full canvas enclosure and much more.  Owner is moving up in size and is open to all offers!Call today to schedule a showing or go to specs to view full listing."
                },
                new Listing {
                    Heading = "40' Sea Ray 400 Sundancer",
                    Type = "Price just reduced",
                    Year = "1998",
                    Price = "US$ 107,500",
                    Location = "Newburyport, MA",
                    Hull = "Fiberglass",
                    Engine = "Twin diesel",
                    YW ="63629-3492595",
                    Photos = photos2,
                    Broker = "Brandon Grigger",
                    Summary = "AT LAST - is a well cared for 40' Sundancer - Powered by Twin 3116 Cat Diesel with Low Hours -  always been professionally maintained.  The 40' Sundancer has a great layout with - Two Staterooms and Two Heads.AT LAST is ready to cruise and is equipped to do so with AC and Heat, Autopilot, Radar, GPS Chartplotter, Generator, Full canvas enclosure and much more.  Owner is moving up in size and is open to all offers!Call today to schedule a showing or go to specs to view full listing."
                },
                new Listing {
                    Heading = "40' Sea Ray 400 Sundancer",
                    Type = "Price just reduced",
                    Year = "1998",
                    Price = "US$ 107,500",
                    Location = "Newburyport, MA",
                    Hull = "Fiberglass",
                    Engine = "Twin diesel",
                    YW ="63629-3492595",
                    Photos = photos2,
                    Broker = "Brandon Grigger",
                    Summary = "AT LAST - is a well cared for 40' Sundancer - Powered by Twin 3116 Cat Diesel with Low Hours -  always been professionally maintained.  The 40' Sundancer has a great layout with - Two Staterooms and Two Heads.AT LAST is ready to cruise and is equipped to do so with AC and Heat, Autopilot, Radar, GPS Chartplotter, Generator, Full canvas enclosure and much more.  Owner is moving up in size and is open to all offers!Call today to schedule a showing or go to specs to view full listing."
                },
                new Listing {
                    Heading = "40' Sea Ray 400 Sundancer",
                    Type = "Price just reduced",
                    Year = "1998",
                    Price = "US$ 107,500",
                    Location = "Newburyport, MA",
                    Hull = "Fiberglass",
                    Engine = "Twin diesel",
                    YW ="63629-3492595",
                    Photos = photos2,
                    Broker = "Brandon Grigger",
                    Summary = "AT LAST - is a well cared for 40' Sundancer - Powered by Twin 3116 Cat Diesel with Low Hours -  always been professionally maintained.  The 40' Sundancer has a great layout with - Two Staterooms and Two Heads.AT LAST is ready to cruise and is equipped to do so with AC and Heat, Autopilot, Radar, GPS Chartplotter, Generator, Full canvas enclosure and much more.  Owner is moving up in size and is open to all offers!Call today to schedule a showing or go to specs to view full listing."
                },
                new Listing {
                    Heading = "40' Sea Ray 400 Sundancer",
                    Type = "Price just reduced",
                    Year = "1998",
                    Price = "US$ 107,500",
                    Location = "Newburyport, MA",
                    Hull = "Fiberglass",
                    Engine = "Twin diesel",
                    YW ="63629-3492595",
                    Photos = photos2,
                    Broker = "Brandon Grigger",
                    Summary = "AT LAST - is a well cared for 40' Sundancer - Powered by Twin 3116 Cat Diesel with Low Hours -  always been professionally maintained.  The 40' Sundancer has a great layout with - Two Staterooms and Two Heads.AT LAST is ready to cruise and is equipped to do so with AC and Heat, Autopilot, Radar, GPS Chartplotter, Generator, Full canvas enclosure and much more.  Owner is moving up in size and is open to all offers!Call today to schedule a showing or go to specs to view full listing."
                },
                new Listing {
                    Heading = "40' Sea Ray 400 Sundancer",
                    Type = "Price just reduced",
                    Year = "1998",
                    Price = "US$ 107,500",
                    Location = "Newburyport, MA",
                    Hull = "Fiberglass",
                    Engine = "Twin diesel",
                    YW ="63629-3492595",
                    Photos = photos2,
                    Broker = "Brandon Grigger",
                    Summary = "AT LAST - is a well cared for 40' Sundancer - Powered by Twin 3116 Cat Diesel with Low Hours -  always been professionally maintained.  The 40' Sundancer has a great layout with - Two Staterooms and Two Heads.AT LAST is ready to cruise and is equipped to do so with AC and Heat, Autopilot, Radar, GPS Chartplotter, Generator, Full canvas enclosure and much more.  Owner is moving up in size and is open to all offers!Call today to schedule a showing or go to specs to view full listing."
                },
                new Listing {
                    Heading = "40' Sea Ray 400 Sundancer",
                    Type = "Price just reduced",
                    Year = "1998",
                    Price = "US$ 107,500",
                    Location = "Newburyport, MA",
                    Hull = "Fiberglass",
                    Engine = "Twin diesel",
                    YW ="63629-3492595",
                    Photos = photos2,
                    Broker = "Brandon Grigger",
                    Summary = "AT LAST - is a well cared for 40' Sundancer - Powered by Twin 3116 Cat Diesel with Low Hours -  always been professionally maintained.  The 40' Sundancer has a great layout with - Two Staterooms and Two Heads.AT LAST is ready to cruise and is equipped to do so with AC and Heat, Autopilot, Radar, GPS Chartplotter, Generator, Full canvas enclosure and much more.  Owner is moving up in size and is open to all offers!Call today to schedule a showing or go to specs to view full listing."
                },
                new Listing {
                    Heading = "40' Sea Ray 400 Sundancer",
                    Type = "Price just reduced",
                    Year = "1998",
                    Price = "US$ 107,500",
                    Location = "Newburyport, MA",
                    Hull = "Fiberglass",
                    Engine = "Twin diesel",
                    YW ="63629-3492595",
                    Photos = photos2,
                    Broker = "Brandon Grigger",
                    Summary = "AT LAST - is a well cared for 40' Sundancer - Powered by Twin 3116 Cat Diesel with Low Hours -  always been professionally maintained.  The 40' Sundancer has a great layout with - Two Staterooms and Two Heads.AT LAST is ready to cruise and is equipped to do so with AC and Heat, Autopilot, Radar, GPS Chartplotter, Generator, Full canvas enclosure and much more.  Owner is moving up in size and is open to all offers!Call today to schedule a showing or go to specs to view full listing."
                },
                new Listing {
                    Heading = "40' Sea Ray 400 Sundancer",
                    Type = "Price just reduced",
                    Year = "1998",
                    Price = "US$ 107,500",
                    Location = "Newburyport, MA",
                    Hull = "Fiberglass",
                    Engine = "Twin diesel",
                    YW ="63629-3492595",
                    Photos = photos2,
                    Broker = "Brandon Grigger",
                    Summary = "AT LAST - is a well cared for 40' Sundancer - Powered by Twin 3116 Cat Diesel with Low Hours -  always been professionally maintained.  The 40' Sundancer has a great layout with - Two Staterooms and Two Heads.AT LAST is ready to cruise and is equipped to do so with AC and Heat, Autopilot, Radar, GPS Chartplotter, Generator, Full canvas enclosure and much more.  Owner is moving up in size and is open to all offers!Call today to schedule a showing or go to specs to view full listing."
                },
                new Listing {
                    Heading = "40' Sea Ray 400 Sundancer",
                    Type = "Price just reduced",
                    Year = "1998",
                    Price = "US$ 107,500",
                    Location = "Newburyport, MA",
                    Hull = "Fiberglass",
                    Engine = "Twin diesel",
                    YW ="63629-3492595",
                    Photos = photos2,
                    Broker = "Brandon Grigger",
                    Summary = "AT LAST - is a well cared for 40' Sundancer - Powered by Twin 3116 Cat Diesel with Low Hours -  always been professionally maintained.  The 40' Sundancer has a great layout with - Two Staterooms and Two Heads.AT LAST is ready to cruise and is equipped to do so with AC and Heat, Autopilot, Radar, GPS Chartplotter, Generator, Full canvas enclosure and much more.  Owner is moving up in size and is open to all offers!Call today to schedule a showing or go to specs to view full listing."
                },
                new Listing {
                    Heading = "40' Sea Ray 400 Sundancer",
                    Type = "Price just reduced",
                    Year = "1998",
                    Price = "US$ 107,500",
                    Location = "Newburyport, MA",
                    Hull = "Fiberglass",
                    Engine = "Twin diesel",
                    YW ="63629-3492595",
                    Photos = photos2,
                    Broker = "Brandon Grigger",
                    Summary = "AT LAST - is a well cared for 40' Sundancer - Powered by Twin 3116 Cat Diesel with Low Hours -  always been professionally maintained.  The 40' Sundancer has a great layout with - Two Staterooms and Two Heads.AT LAST is ready to cruise and is equipped to do so with AC and Heat, Autopilot, Radar, GPS Chartplotter, Generator, Full canvas enclosure and much more.  Owner is moving up in size and is open to all offers!Call today to schedule a showing or go to specs to view full listing."
                },
                new Listing {
                    Heading = "40' Sea Ray 400 Sundancer",
                    Type = "Price just reduced",
                    Year = "1998",
                    Price = "US$ 107,500",
                    Location = "Newburyport, MA",
                    Hull = "Fiberglass",
                    Engine = "Twin diesel",
                    YW ="63629-3492595",
                    Photos = photos2,
                    Broker = "Brandon Grigger",
                    Summary = "AT LAST - is a well cared for 40' Sundancer - Powered by Twin 3116 Cat Diesel with Low Hours -  always been professionally maintained.  The 40' Sundancer has a great layout with - Two Staterooms and Two Heads.AT LAST is ready to cruise and is equipped to do so with AC and Heat, Autopilot, Radar, GPS Chartplotter, Generator, Full canvas enclosure and much more.  Owner is moving up in size and is open to all offers!Call today to schedule a showing or go to specs to view full listing."
                }
            };
            return listings;
        }

        //  Async example
        //[ApiController]
        //[Route("api/[controller]")]
        //public class ItemsController : ControllerBase
        //{
        //    private readonly IItemRepository _repository;

        //    public ItemsController(IItemRepository repository)
        //    {
        //        _repository = repository;
        //    }

        //    [HttpGet]
        //    public async Task<ActionResult<IEnumerable<MyItem>>> GetItems()
        //    {
        //        var items = await _repository.GetAllItemsAsync();
        //        return Ok(items);
        //    }
        //}
    }
}
