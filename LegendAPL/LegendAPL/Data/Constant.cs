using LegendALP.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LegendALP.Data
{
    public class Constant
    {
        public const string ToEmail = "info.singapore@legendasia.com";

        public const string FromEmail = "no-reply@legendasia.com";

        public const string Subject = "Enquiry on Legend Logistics Group";

        public const string Body = "<font> Dear Team, <br/><br> Below are the information:- <br/><br/> Name:- {0} <br/><br/> EmailID:- {1} <br/><br/> Subject:- {2} <br/><br/> Message:- {3}" +
            "</font>" +
            "<br/><br/><font size=2><i>[This is an automated message - Please do not reply directly to this email. " +
            "If you need additional help, please contact info@legendasia.com]</i></font>";

        public static NewsModel NewsList(string ID)
        {
            NewsModel contactDetails = new NewsModel();
            if (ID == "Jan1218")
            {
                contactDetails.IDNews = "Jan1218";
                contactDetails.NewsYear = "2018";
                contactDetails.NewsHeader = "Legend expands to Australia";
                contactDetails.NewsDate = "12 January 2018";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N18/news9.webp' style='width:50%;' class='responsive'>";
                contactDetails.NewsText = "<p class='obiz'>Legend is proud to announce its' latest footprint - AUSTRALIA!</p>" +
                "<p class='obiz' style='padding:10px 0px 0px 0px'>With headquarters in Singapore, Legend&apos;s service coverage now spans across Australia. Legend is very excited and all " +
                "geared up to be part of the big transition of Victoria&apos;s future into a renewable clean energy landscape!</p><br>";
            }
            if (ID == "Dec1218")
            {
                contactDetails.IDNews = "Dec1218";
                contactDetails.NewsYear = "2018";
                contactDetails.NewsHeader = "Legend Shipping completes acquisition of Tank subsidiary";
                contactDetails.NewsDate = "12 December 2018";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N18/news6.webp' style='width:50%;' class='responsive'>";
                contactDetails.NewsText = "<p class='obiz' style='text-align:justify;'>On 11 December 2018, Legend Shipping completed the final tranche of the acquisition of Legend Tank, a private company " +
                "and Legend subsidiary co-owned by Mr Reynard Ong Purnata.</p><p class='obiz' style='padding:10px 0px 0px 0px;text-align:justify;'> Mr Ong is part of the Purnata family which owns PT. " +
                "Djasa Bahari, an Indonesian shipping company established in 1967 with diversified interests in logistics and supply chain.</p>" +
                "<p class='obiz' style='padding:10px 0px 0px 0px;text-align:justify;'>Legend Shipping has bought out the remaining shares of Legend Tank from Mr Ong, to become a wholly-owned subsidiary " +
                "of Legend Shipping Pte Ltd.</p>" +
                "<p class='obiz' style='padding:10px 0px 0px 0px;text-align:justify;'>Commenting on this important milestone, Legend Group MD Mr CK Than said “This acquisition will enable us to bring " +
                "forward the strategic plan in a unilateral effort.</p><br>";
            }
            if (ID == "Dec1418")
            {
                contactDetails.IDNews = "Dec1418";
                contactDetails.NewsYear = "2018";
                contactDetails.NewsHeader = "Private equity fund managed by ACA Investments Pte Ltd has invested into Legend Shipping Pte Ltd";
                contactDetails.NewsDate = "14 December 2018";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N18/news5.webp' style='width:50%;' class='responsive'>";
                contactDetails.NewsText = "<p class='obiz'>After two days of discussion, Legend Shipping concluded its Regional Meeting today with a broad set of recommendations on development strategies " +
                "and especially strengthening Legend&apos;s brand in ISO tank business on a larger scale.</p>" +
                "<p class='obiz' style='padding:10px 0px 0px 0px'> The effective dialogue brought together Singapore, Malaysia and India&apos;s business heads; over past year&apos;s reflection, sharing of " +
                "ideas and collaboration.</p>" +
                "<p class='obiz' style='padding:10px 0px 0px 0px'> But for now, it&apos;s almost time to celebrate the year that was.</p>" +
                "<p class='obiz' style='padding:10px 0px 0px 0px'> And the Legend management wishes all staff, customers and friends the very best for a safe and joyful festive season!</p><br>";
            }
            if (ID == "Apr19")
            {
                contactDetails.IDNews = "Apr19";
                contactDetails.NewsYear = "2019";
                contactDetails.NewsHeader = "Legend introduces specialised trucking services";
                contactDetails.NewsDate = "April 2019";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N19/news3.webp' style='width:50%;' class='responsive'>";
                contactDetails.NewsText = "<p class='obiz' style='text-align:justify;'>Legend Shipping Group is pleased to announce its most recent expansion of our new service into Specialised" +
                "Trucking Services with a fleet of trucks, expandable trailers, flatbed, stepbed, tank trailers, and modifiable purpose-built trailers.</p>" +
                "<p class='obiz' style='padding:10px 0px 0px 0px;text-align:justify;'> With this, Legend&apos;s Australian subsidiary adds on a new heavy haul business unit which provide trucking " +
                "services to the mining, oil & gas, construction, manufacturing industries, energy and major project works.</p>" +
                "<p class='obiz' style='padding:10px 0px 0px 0px;text-align:justify;'> Combining transport engineering and heavy lift skill set, Legend now has the scale, breadth and capabilities " +
                "to compete more effectively and profitably in the Australian heavy haulage market, delivering compelling value to new stakeholders.</p>" +
                "<p class='obiz' style='padding:10px 0px 0px 0px;text-align:justify;'> We view this as an exciting opportunity to continue to innovate and invest in a sustainable business future!</p>" +
                "<p class='obiz' style='padding:10px 0px 0px 0px;text-align:justify;'> The quality of dedication and customer satisfaction is very important for the Group’s long-term success.Legend looks " +
                "forward to be of better service to its customers and partners.</p><br>";
            }
            if (ID == "Sep2419")
            {
                contactDetails.IDNews = "Sep2419";
                contactDetails.NewsYear = "2019";
                contactDetails.NewsHeader = "Legend takes delivery of Faymonville telemax trailers";
                contactDetails.NewsDate = "24 Sep 2019";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N19/news2.webp' style='width:50%;' class='responsive'>";
                contactDetails.NewsText = "<p class='obiz'> On 1st September, Legend took delivery of 2 units brand new Faymonville telemax trailers.</p>" +
                "<p class='obiz' style='padding:10px 0px 0px 0px'> With this 4-axle TELEMAX 55-meter extendable trailers, Legend will be better equipped with a higher capability to bid for " +
                "a wide variety of projects including wind.</p>" +
                "<p style='color:#183682;font-weight:bold;'>Techinal Data:</p>" +
                "<div style='overflow-x:auto;'><table style='width:50%;font-size:15px; color: #6b6a6a;line-height:1.2em;'><tr><td>Speed : </td><td>80 km/h</td><td>Rear goose neck swing ± :</td><td>2700 mm</td>" +
                "</tr><tr><td>Gross weight: </td><td> 73000 kg </td><td> Fifth wheel height loaded ± :  </td><td>1290 mm</td></tr><tr><td>King pin load :</td><td> 25000 kg </td><td> Extendable : </td><td>36800 mm</td>" +
                "</tr><tr><td>Axle load :</td><td>48000 kg </td><td>Air suspension ± : </td><td> 75/+125 mm</td></tr><tr><td>Tare Weight ± :</td><td> 20420 kg</td><td> Axle distance : </td>" +
                "<td>1810 mm</td></tr><tr><td>Loading length ± : </td><td>18000 mm</td><td>Total width ± :</td><td>2480 mm</td></tr></table></div><br>";
            }
            if (ID == "Dec1019")
            {
                contactDetails.IDNews = "Dec1019";
                contactDetails.NewsYear = "2019";
                contactDetails.NewsHeader = "Private equity fund managed by ACA Investments Pte Ltd has invested into Legend Shipping Pte Ltd";
                contactDetails.NewsDate = "10 December 2019";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N19/ACAXLegend.png' style='width:50%;' class='responsive'>";
                contactDetails.NewsText = "<p class='obiz'><a href='../Content/documents/PressReleaseACA.pdf' download='' target='_blank' style='color:#183682;font-weight:bold;'> Download Press Release </a></p>" +
                "<p class='obiz' style='padding:10px 0px 0px 0px'> Legend Shipping Pte Ltd and its subsidiaries (collectively “Legend Logistics Group”) is pleased to announce the successful closing of approximately " +
                "US$7 million in fundraising from ACA Investments Pte Ltd, a leading private equity investment firm.</p><br>";
            }
            if (ID == "Dec2919")
            {
                contactDetails.IDNews = "Dec2919";
                contactDetails.NewsYear = "2019";
                contactDetails.NewsHeader = "Change of company name";
                contactDetails.NewsDate = "29 December 2019";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N19/LegendGrouplogo.webp' style='width:50%;' class='responsive'>";
                contactDetails.NewsText = "<p class='obiz'> Dear Valued Partners,</p>" +
                "<p class='obiz' style='padding:10px 0px 0px 0px;text-align:justify;'>Since its’ inception in 2005, Legend has developed itself to be one of Asia&apos;s leading specialised logistics " +
                "provider with diversified interest in container and agency services.</p>" +
                "<p class='obiz' style='padding:10px 0px 0px 0px;text-align:justify;'> To be in line with the Group&apos;s business and activities, Legend is rebranding itself. " +
                "Legend Shipping Pte Ltd (ROC:201209737N), effective 1st Jan 2020, the company will be therefore known as Legend Logistics Pte Ltd.</p>" +
                "<p class='obiz' style='padding:10px 0px 0px 0px;text-align:justify;'> With the rebranding, all business activities, shall be performed thru its wholly owned subsidiary, Legend Logistics " +
                "(Asia) Pte Ltd, Singapore, which includes Container Shipping, Tank Container and Specialised Logistics.</p>" +
                "<p class='obiz'style='padding:10px 0px 0px 0px;text-align:justify;'> The new name symbolizes our dedication to the logistics industry and the significant expansion of our business activities.</p>" +
                "<p class='obiz' style='padding:10px 0px 0px 0px;text-align:justify;'> As always, Legend endeavours towards providing exceptional customer service. We thank you for your business and look forward " +
                "to your continued support as we embark onto this exciting phase of progress.</p><br>";
            }
            if (ID == "Mar1020")
            {
                contactDetails.IDNews = "Mar1020";
                contactDetails.NewsYear = "2020";
                contactDetails.NewsHeader = "Legend announces its new office in Ho Chi Minh, Vietnam";
                contactDetails.NewsDate = "10 March 2020";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N20/VietnamAnnoucement.webp' style='width:50%;' class='responsive'>";
                contactDetails.NewsText = "<p class='obiz' style='text-align:justify;'> Legend is pleased to announce the opening of its new office in Ho Chi Minh, LEGEND LOGISTICS (VIETNAM) CO., LTD. As a leader in the " +
                "logistics industry, Legend strategically selected Vietnam to accommodate the increasing demand in the market and to expand and create a stronger presence in Asia.</p>" +
                "<p class='obiz' style='padding:10px 0px 0px 0px'> The new office will enable Legend to further leverage its service network and strengthen our service capabilities across the region.</p><br>";
            }
            if (ID == "Mar2520")
            {
                contactDetails.IDNews = "Mar2520";
                contactDetails.NewsYear = "2020";
                contactDetails.NewsHeader = "Commencement of feeder (COC) service between Port Klang – Kuala Tanjung Port";
                contactDetails.NewsDate = "25 March 2020";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N20/FeederAnnouncement.webp' style='width:50%;' class='responsive'>";
                contactDetails.NewsText = "<p class='obiz'><a href='../Content/documents/PressReleaseContainerFeederService.pdf' download='' target='_blank' style='color:#183682;font-weight:bold;'> Download Company Announcement </a></p>" +
                "<p class='obiz' style='padding:10px 0px 0px 0px;text-align:justify;'> Legend Logistics Group is pleased to announce the commencement of its new feeder (COC) service between Port Kelang – Kuala Tanjung Port with the " +
                "deployment of the first set of tug and barge (IG Bravo and IG 2510), making its maiden call at Port Kelang on 25th March 2020 and Kuala Tanjung Port on 28th March 2020.</p>" +
                "<p class='obiz' style='padding:10px 0px 0px 0px;text-align:justify;'> The barge (IG 2510) provides a trade capacity of 210teus laden (nominal capacity is 352teus), offering fixed weekly sailing schedule.</p>" +
                "<p class='obiz' style='padding:10px 0px 0px 0px;text-align:justify;'> Strategically located along the Malacca Straits, Kuala Tanjung Port is set to become Indonesia&apos;s biggest port in the West Archipelago. " +
                "In its first phase of completion, Kuala Tanjung Multipurpose Terminal (KTMT) is already offering facilities of three ship-to-shore cranes, eight automated rubber-tired gantry cranes, two mobile harbour cranes " +
                "for containers and dry bulk goods.</p>" +
                "<p class='obiz' style='padding:10px 0px 0px 0px;text-align:justify;'> With a number of reputable factories operating in Kuala Tanjung Industrial Estate that encompasses the Sei Mengkei Special Economic Zone, " +
                "Legend aims to seize the opportunity as a first mover advantage and game changer to expand into this new service with a strong value proposition for its customers.</p>" +
                "<p class='obiz' style='padding:10px 0px 0px 0px;text-align:justify;'> This inaugural Kuala Tanjung feeder service sets an important milestone for Legend, value adding its solutions as a regional feeder services " +
                "at operationally challenged ports.</p><br>";
            }
            if (ID == "Jul2320")
            {
                contactDetails.IDNews = "Jul2320";
                contactDetails.NewsYear = "2020";
                contactDetails.NewsHeader = "Change of company name to Legend Logistics Limited";
                contactDetails.NewsDate = "23 July 2020";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N19/LegendGrouplogo.webp' style='width:50%;' class='responive'>";
                contactDetails.NewsText = "<a href='#' name='#4'></a>" +
                "<p class='obiz'> With effective from 23rd July 2020, please be informed that Legend Logistics Pte Ltd has been converted to a Public Company Limited by Share. Hence, we are now known as " +
                "Legend Logistics Limited (the &quot;Company&quot;).</p><br>";
            }
            if (ID == "Aug1020")
            {
                contactDetails.IDNews = "Aug1020";
                contactDetails.NewsYear = "2020";
                contactDetails.NewsHeader = "Legend Singapore celebrates National Day 2020";
                contactDetails.NewsDate = "10 August 2020";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N20/Singapore.webp' style='width:50%;' class='responive'>";
                contactDetails.NewsText = "<p class='obiz'> Our Singapore. Our Enterprises.<a href='#' name='#3'></a><br>These are unprecendented times for businesses, but that doesn&apos;t stop us from " +
                "celebrating as one united people.<br> Together, we will forge a brave new world and emerge stronger.<br> Happy birthday #Singapore!<br><br>#SGUnited #TogetherStrongerSG #ndp2020 #legendgroup</p><br>";
            }
            if (ID == "Oct0920")
            {
                contactDetails.IDNews = "Oct0920";
                contactDetails.NewsYear = "2020";
                contactDetails.NewsHeader = "Legend Australia takes delivery of two brand new Scania trucks";
                contactDetails.NewsDate = "09 October 2020";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N20/Newscania.webp' style='width:50%;' class='responive'>";
                contactDetails.NewsText = "<p class='obiz'>Legend Australia added two brand new Scania trucks to our growing fleet. These new trucks will be used for the safe and efficient " +
                "transportation of Out of Gauge (OOG) cargoes for our clients mainly from infrastructure and construction industries.</p>" +
                "<p style='color:black;font-weight:bold;font-size:15px;'>Techinal Data:</p>" +
                "<p class='obiz'>Axle distance: 3150<br>Max. weight technical Front: 7500 (3X29 AM420S)<br> Max. weight technical Rear: 21000 (10500+10500) (AIR 2 AD400SAP AD400SAP)</p>" +
                "<div style='overflow-x:auto;'><table style='width:40%;font-size:15px; color: #6b6a6a;line-height:1.2em;'><tr><th>Weights [kg] </th><th>Front Tractor</th><th>Rear</th><th>Total</th></tr>" +
                "<tr><td>Chassis weight </td><td>5462</td><td>3860</td><td>9322</td></tr><tr><td>Extra weight (Chassis) </td><td> 456  </td><td> -82   </td><td>374</td>" +
                "</tr><tr><td>Equipment</td><td> 2   </td><td>  214 </td><td>216</td></tr><tr><td>Equipment</td><td>5920 </td><td>3992 </td><td> 9912</td></tr>" +
                "<tr><td>Weight unloaded</td><td>  5920</td><td> 3992 </td><td>9912</td></tr><tr><td>Payload</td><td>0</td><td>0</td><td>0</td></tr>" +
                "<tr><td>Weight loaded</td><td>5920 </td><td>3992 </td><td>9912</td></tr><tr><td>Max. weight </td><td>6500 </td><td>16500 </td><td>23000</td></tr>" +
                "<tr><td>Weight reserve</td><td>580</td><td>12508</td><td>13088</td></table><br></div><br>";
            }
            if (ID == "Nov1320")
            {
                contactDetails.IDNews = "Nov1320";
                contactDetails.NewsYear = "2020";
                contactDetails.NewsHeader = "Legend Logistics Group wins the SMEs Excellence Growth Award at the ASEAN Business Awards 2020";
                contactDetails.NewsDate = "13 November 2020";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N20/new13nov2020.webp' style='width:50%;' class='responive'>";
                contactDetails.NewsText = "<p class='obiz' style='text-align:justify;'>Legend Logistics Group has won the renowned SME Excellence Growth Award at the ASEAN Business Awards (ABA) 2020 which was held on 13th November 2020 at Hanoi, Vietnam. This award honors companies that have outstanding commercial success and sustainable growth. </p> " +
                "<p class='obiz' style='text-align:justify;'> The ABA brings meaningful recognition for ASEAN business as they show solidarity and great ability to weather the impacts of the ongoing pandemic, while also contributing to the governments of ASEAN countries to gradually overcome the situation.</p> " +
                "<p class='obiz' style='text-align:justify;'> The ABA 2020 award system is divided into ten categories including Priority Integration Sectors; SMEs Excellence; Young Entrepreneurs; Woman Entrepreneurs; Family Business; Skills Development; Friends of ASEAN; Inclusive Business; Combating Covid-19 and Country Star of the Year.</p> " +
                "<p class='obiz' style='text-align:justify;'> This year's ABA ceremony was held in the form of a combination of live and online conferences so that businesses unable to attend due to pandemic restrictions could still watch and interact. Mr. CK Than, CEO of Legend Logistics Group commented via video link, “It’s an honor to receive this prestigious award. This award motivates us to continue driving our business into ASEAN to contribute to the inclusive growth and prosperity of the entire region.”</p> ";
            }
            if (ID == "Dec3020")
            {
                contactDetails.IDNews = "Dec3020";
                contactDetails.NewsYear = "2020";
                contactDetails.NewsHeader = "Legend Carrier Group completes acquisition of IG Logistics Group";
                contactDetails.NewsDate = "30 December 2020";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N20/30dec2020.webp' style='height:100%;width:50%;'>";
                contactDetails.NewsText = "<p class='obiz' style='text-align:justify;'> Legend Logistics Limited and its subsidiaries (collectively “Legend Logistics Group”) is pleased to " +
                "announce that its subsidiary Legend Carrier Group Pte Ltd (&quot;Legend Carrier Group&quot;) has acquired 100% of iG Logistics Group (&quot;iG&quot;)." +
                "<a href='#' name='#3'></a><br><br> Founded in 2013, iG is a provider of logistics and marine services. With its own fleet of marine vessels, iG offers feeder shipping and " +
                "transportation services particularly to the out-ports of Batam and Bintan in Indonesia and other ports in ASEAN. Together with its logistics strength, iG provides multi-modal " +
                "logistics solutions and door-to-door logistics services to various industries.<br><br> Through this acquisition, Legend Carrier Group will be able to provide its customers with " +
                "an integrated logistics platform and increase its capabilities to deliver customised multi-modal logistics solutions encompassing marine logistics and chartering services, container " +
                "liner and feeder services, liquid bulk in ISO Tanks, land transportation, automotive logistics, warehousing, global freight management / forwarding and agency support services, " +
                "with strategic focus on Sumatra and Riau Islands (Batam, Bintan and Bangka) in Indonesia, ports in ASEAN and in the Far East connecting to ports in Bay of Bengal, Indian Sub-Continent " +
                "and Arabian Gulf.<br><br> Mr. CK Than, Chairman/Group CEO of Legend Logistics Group said, &quot;We welcome iG Logistics Group into Legend family. This acquisition allows Legend to leverage on " +
                "iG Logistics&apos; established strong sales and distribution network; and gives Legend the access to new markets in Riau Island and Sumatra region. Post-acquisition, Legend will be injecting its " +
                "Container Shipping Business into Legend Carrier Group to pursue its growth as a Regional Container and Breakbulk Carrier.&quot;<br><br></p><br>";
            }
            if (ID == "Jan1821")
            {
                contactDetails.IDNews = "Jan1821";
                contactDetails.NewsYear = "2021";
                contactDetails.NewsHeader = "Legend Logistics Australia has been awarded a contract on AUD 6.7 Billion West Gate Tunnel Project";
                contactDetails.NewsDate = "18 January 2021";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N21/WGTPcopy.webp' style='width:50%;' class='responive'/>";
                contactDetails.NewsText = "<p class='obiz' style='text-align:justify;'> Legend Australia, a Melbourne-based integrated specialised logistics company, has been awarded a major line-haul contract with CPB+John Holland JV on the West " +
                "Gate Tunnel Project (WTGP).  WGTP is an AUD 6.7 billion project that links the West Gate Freeway at Yarraville with the Port of Melbourne and CityLink at Docklands via twin tunnels beneath Yarraville. <a href='#' name='#3'></a>" +
                "<br><br> As part of its contract, Legend will be providing the transportation and storage of the precast materials including parapet, barriers, noise walls and tunnel segments.<br><br> Legend anticipates, at the peak of the project, " +
                "operations will run 24/7, in order to keep the back stack adequately replenished for the tunnel boring machines.<br><br> With up to 50 percent of the loads exceeding concessional mass limits of 42.5 tonnes, the tunnel segment loads " +
                "will be moved on Legend’s custom A-doubles which have an approved payload of 56.5 tonnes.<br><br> To accommodate the higher mass limits, the commercial vehicles deployed on the project will primarily consist of Scania R 620 6x4s " +
                "owered by a Euro 5 DC16 engines.<br><br> According to Legend Australia General Manager Troy Eiken, fuel usage, manoeuvrability, comfort for drivers and reliability helped determine the preference for commercial vehicles on the " +
                "project.<br><br> This will include some prime movers from Kenworth and Mercedes-Benz.<br><br> Already in its infancy, the contract is expected to run over the next three years.<br><br> Initial indications are for anywhere up to " +
                "25 prime movers and over 20 A-Double sets of trailers to be required.<br><br> The custom-built trailer fleet is supplied by Vawdrey and MaxiTrans and includes drop deck and flat top skel trailers set up as A-Doubles.<br><br> Eiken " +
                "said Legend were able to secure the contract by engineering modern methods of transport and logistics solutions that increased safety and productivity.<br><br> &quot;It means a lot for Legend Australia and Legend globally that " +
                "we have been awarded this contract,&quot; said Eiken.<br><br> &quot;It shows that the policies and procedures that we are continually introducing, work within a Tier 1 environment and it also shows just reward for all the hard " +
                "work our team are putting in to show the industry an innovative approach to transport and logistics,&quot; he said.</p><br>";
            }
            if (ID == "Jan2821")
            {
                contactDetails.IDNews = "Jan2821";
                contactDetails.NewsYear = "2021";
                contactDetails.NewsHeader = "Legend India has announced the opening of its new tank container depot at Nhava Sheva, India";
                contactDetails.NewsDate = "28 January 2021";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N21/NSADepot.webp' style='width:50%;' class='responsive'>";
                contactDetails.NewsText = "<p class='obiz' style='text-align:justify;'> Legend is pleased to announce the opening of its new tank container depot at Nhava Sheva, India. The depot is strategically located 13kms away from Jawaharlal " +
                "Nehru Port (JNPT) and covers an area of 5 acres (20,000 sqm.) <a href='#' name='#3'></a><br><br> It offers the following 24x7 services for ISO tanks with high quality standards to meet the requirements of our customers from various " +
                "industries.<br> •\tStorage for empty containers<br> •\tCleaning of ISO tank containers<br> •\tPeriodic testing of ISO tank containers<br> •\tRepair and maintenance of all containers<br />  •\tSpecial repairs (dents, pit repair & " +
                "shell crack) - according to applicable standards<br> •\\tModifications of containers as per requirement of customers/client<br><br> The establishment of tank container depot offers an integrated suite of value-added services to our " +
                "customers and promotes a strategic and cost-effective logistic partnering in the tank container and dry boxes business for a sustainable growth.</p><br>";
            }
            if (ID == "Mar0121")
            {
                contactDetails.IDNews = "Mar0121";
                contactDetails.NewsYear = "2021";
                contactDetails.NewsHeader = "Legend expands its footprint to the Netherlands";
                contactDetails.NewsDate = "01 March 2021";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N21/Netherlands.webp' style='width:50%;' class='responsive'>";
                contactDetails.NewsText = " <p class='obiz' style='text-align:justify;'> Legend is proud to announce the opening of its new office, LEGEND LOGISTICS (EUROPE) BV, in the Netherlands on 1st March 2021. Capitalising on Netherlands " +
                "as a strategic geographical location in Europe, Legend Netherlands office was setup to represent Legend Group interest in Europe.<a href='#' name='#3'></a><br><br> Legend Netherlands provides comprehensive logistics solutions " +
                "for bulk liquid products tailored to our customers&apos; requirements and specifications. Our suite of services includes bulk liquid logistics and tank container specialised services such as washing, storing, heating and handling " +
                "of tank containers.</p><br>";
            }
            if (ID == "Mar2421")
            {
                contactDetails.IDNews = "Mar2421";
                contactDetails.NewsYear = "2021";
                contactDetails.NewsHeader = "Legend Logistics Limited wins the Special Award for Internationalisation at the Enterprise 50";
                contactDetails.NewsDate = "24 March 2021";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N21/AwardImage.webp' style='width:50%;' class='responsive'>";
                contactDetails.NewsText = "<p class='obiz' style='text-align:justify;'> Legend Logistics Limited is proud to announce that we ranked 12th among the top 50 privately-held local companies and won the Special Award for " +
                "Internationalisation at the Enterprise 50 2020 Awards which was held on 23 March 2020.<a href='#' name='#3'></a><br><br> The E50 Awards recognises the 50 most enterprising local, privately-held companies who have " +
                "contributed to the economic development of Singapore, both locally and overseas.  It is jointly organised by The Business Times and KPMG in Singapore, supported by Enterprise Singapore, the Singapore Business Federation " +
                "and the Singapore Exchange, and sponsored by OCBC Bank. Over the last year, Legend further expanded its footprints to South East Asia by establishing own offices in Thailand, Vietnam and Indonesia. Legend also vertically " +
                "integrated its business upstream and downstream by adding in marine logistics, container depots, land logistics and warehousing services to its wide range of diversified logistics solutions. Today, Legend operates in 11 " +
                "regional offices across 8 countries with presence in Asia, Oceania and Europe.<br><br> &quot;It is with a great honour to be receiving this prestigious award from E50 and to be recognised as a top homegrown business " +
                "in 2020 despite the challenges posed by Covid-19. We believe that this recognition will strengthen our brand and create more opportunities as we continue to expand our footprints globally. This award also further motivates " +
                "us to achieve greater heights through our innovative strategies and business models.&quot; said Mr. CK Than, Group CEO of Legend Logistics Limited.</p><br>";
            }
            if (ID == "Jul0521")
            {
                contactDetails.IDNews = "Jul0521";
                contactDetails.NewsYear = "2021";
                contactDetails.NewsHeader = "Legend Logistics raises strategic investment from EDBI to Drive regional growth and digitalisation plans";
                contactDetails.NewsDate = "05 July 2021";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N21/Legend_and_EDBI_V2_modified1.webp' style='width:50%;' class='responsive'>";
                contactDetails.NewsText = "<p class='obiz'><a href='../Content/documents/05 Jul_Press Release_Legend Logistics raises strategic investment from EDBI.pdf' name='#3' style='color:#183682;font-weight:bold;' download=''>Download Press Release" +
                "</a><br><h5 style='font-size: 15px;'>Legend Logistics well poised to capture growth opportunities in regional supply chains, as it expands offerings and embarks on digital transformation</h5></p>" +
                "<p class='obiz'><h5 style='font-size: 15px;'>Accelerating growth across South and Southeast Asia enabled by Diversified Offerings, Enhanced Connectivity and Digitalisation</h5></p>" +
                "<p class='obiz' style='text-align:justify;'><b style='color: black;font-size: 15px;font-weight:600;'>Singapore, 05 July 2021 –</b> Legend Logistics Limited (“Legend”) today announced ongoing regional expansion efforts across Asia, " +
                "including the closing of their acquisition of iG Logistics Group, and plans for digital transformation and adoption of technology-enabled solutions to further enhance operational visibility and efficiency, enabled by a new" +
                "strategic investment from EDBI, a global Asian-based investor.</p>" +
                "<p class='obiz' style='text-align:justify;'> Legend was founded in 2012 as a Singapore-based freight forwarder and has grown into an integrated specialized logistics group offering diversified and cost-effective solutions to " +
                "its customers. Against the backdrop of COVID-19 and the ensuing supply chain disruptions, the company has strengthened its market position in global supply chains by expanding to Europe and the Middle East whilst broadening and " +
                "deepening its Asia presence. It has also embarked on a transformation journey to digitalise business processes and enhance operational visibility, enabling a seamless endto-end logistics experience for customers and stakeholders " +
                "alike.</p><br /><h5 style='font-size:15px;'>Regional Expansion Focusing on Southeast Asia and South Asia</h5>" +
                "<p class='obiz' style='text-align:justify;'> Amidst Legend&apos;s ongoing expansion and transformation efforts, South Asia and Southeast Asia remain the key growth markets for the company. The rapid economic expansion experienced " +
                "in recent years coupled with the region&apos;s geographic and socio-political diversity has meant that the development of logistics infrastructure has been unable to keep pace with demand. For instance, Indonesia alone has over 6,000 " +
                "inhabited islands, and transportation networks are still undeveloped, particularly beyond the main island of Java. Legend Logistics, with its expertise and capabilities in integrated specialized logistics, is well placed to capture " +
                "opportunities emerging from ports with poor logistics infrastructure, offering improved visibility of operational efficiency and cost effectiveness across the supply chain. With the added logistics networks and transit nodes, " +
                "the company will also further improve connectivity at these operationally challenged ports.</p>" +
                "<p class='obiz' style='text-align:justify;'> The investment from EDBI supports the company&apos;s transformation and regional growth plans including M&A, allowing it to expand its service offerings and accelerate market access. " +
                "Legend&apos;s recent acquisition of iG Logistics Group, a vessel and automotive operator, has contributed to the upstream diversification of the company&apos;s services, enabling it to provide integrated customised multi-modal " +
                "logistics solutions encompassing marine logistics and breakbulk services, container shipping and feeder services, and bulk liquids logistics. This complements Legend&apos;s strategic focus of connecting Sumatra and Riau Islands " +
                "in Indonesia and ports across Southeast Asia and the Far East, with ports in the India Subcontinent and the Middle East.</p>" +
                "<p class='obiz' style='text-align:justify;'> &quot;Today, Legend is one of the most diversified transportation companies in Asia and a one-stop integrated and specialised logistics provider with vested interest in specialised logistics, " +
                "tank containers and container shipping for heavy haulage, bulk liquid, dry commodities, perishable products and oversized cargoes. With a presence spanning Asia, Oceania and Europe, Legend operates 11 regional offices across 8 " +
                "countries.&quot; Mr. CK Than, founder and CEO of Legend Logistics Group said. Mr Than added: &quot;The acquisition of iG Logistics Group has strengthened our position as one of the leading container operators in the region. " +
                "Legend is looking to further entrench our position in the region by developing new shipping routes plying emerging and niche markets, deploying our marine assets and equipment, vertically integrating and bringing our services closer " +
                "to our customers.&quot;</p><br /><h5 style='font-size:15px;'>Enhancing Connectivity via Digitalisation</h5>" +
                "<p class='obiz' style='text-align:justify;'> As connectivity and infrastructure of the region&apos;s ports improve, new technology-enabled solutions offering enhanced visibility, automation and centralized operational control have also " +
                "begun to emerge and gain adoption. Building upon Legend&apos;s extensive experience and deep expertise in the logistics industry, the Group recognizes the importance of digitalization and plans to create an innovative business model " +
                "that will further accelerate growth and bolster its competitive advantage both locally and globally. Plans are underway for the Group to adopt digital technologies and solutions into their business processes and services that will " +
                "focus on the pillars of business operations and customer relationships. Legend understands that digitalisation will help satisfy their business-critical needs including optimisation, automation, efficiency, connectivity, and visibility. " +
                "Digital innovation will further benefit Legend to compete strongly in the global supply chain market and create more business opportunities.</p>" +
                "<p class='obiz' style='text-align:justify;'>&quot;We are honoured and delighted to welcome an international renowned investor like EDBI to join the Legend family. EDBI as an invaluable strategic partner with their extensive network " +
                "will add significant value to our expansion worldwide. Moreover, EDBI&apos;s strong knowledge and experience in technologies will help us guide in our digitalization journey and together with Daiwa ACA support the vision of the " +
                "Company.&quot; added Mr Than.<br><br> Ms Chu Swee Yeok, CEO and President of EDBI said, &quot;Southeast Asia continues to grow in importance as a global production base and demand driver, with regional logistics players poised to " +
                "benefit from this trend. Legend Logistics is a key supply chain management partner to a diverse range of global brands and already a regional leader in multimodal logistics. EDBI looks forward to working with Mr CK Than and his " +
                "team to support Legend&apos;s next phase of growth, accelerating market expansion and digitalization, and further strengthening Singapore’s position as a transshipment hub of choice.&quot;</p><br>";
            }
            if (ID == "Sep1721")
            {
                contactDetails.IDNews = "Sep1721";
                contactDetails.NewsYear = "2021";
                contactDetails.NewsHeader = "Legend announces the opening of its new office in Shanghai, China";
                contactDetails.NewsDate = "17 September 2021";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N21/ShanghaiChina.webp' style='width:50%;' class='responsive'>";
                contactDetails.NewsText = "<p class='obiz'> Legend is proud to announce the opening of its new office in Shanghai, China. This is part of our ongoing efforts to expand our reach and make our logistics services " +
                "widely available in the region.<br><br> The new office provides logistics solutions for shipment of any freight including bulk liquid chemicals, consumer perishables, and dry commodities. Legend Shanghai also offers " +
                "agency services for tank/container shipping. With China being one of our key markets, the Shanghai office will enable us to further strengthen our capabilities in the Far East region by leveraging our global network " +
                "and reliable logistics services.</p><br>";
            }
            if (ID == "Sep2921")
            {
                contactDetails.IDNews = "Sep2921";
                contactDetails.NewsYear = "2021";
                contactDetails.NewsHeader = "Legend launches its new direct feeder service between Pasir Gudang and Kuala Tanjung";
                contactDetails.NewsDate = "29 September 2021";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N21/Pasir.webp' style='width:50%;' class='responsive'>";
                contactDetails.NewsText = "<p class='obiz'> Legend is pleased to announce the commencement of our new direct feeder service between Pasir Gudang and Kuala Tanjung on a weekly sailing schedule. " +
                "This is our fourth direct call on top of our existing feeder services.<br><br> • Kuala Tanjung to Port Klang<br> • Batam (Batu Ampar B99) to Singapore<br> • Bintan (Lobam) to Singapore<br>" +
                " • Pasir Gudang to Kuala Tanjung (new service)<br><br> We offer unique shipping solutions via regular and dedicated liner and feeder services using our purpose-built vessels. With our extensive " +
                "experience in the industry and a team of dedicated specialists, Legend provides transport and shipping solutions for containerized cargos, breakbulk, RORO, and project cargos.<br><br> " +
                "Contact our Feeder & Liner Teams for any booking enquiries!<br><br><a href='mailto:all.feeder@legendasia.com' class='anchorStyling'>all.feeder@legendasia.com</a><br>" +
                "<a href='mailto:trade.container@legendasia.com' class='anchorStyling'>trade.container@legendasia.com</a></p><br>";
            }
            if (ID == "Oct2721")
            {
                contactDetails.IDNews = "Oct2721";
                contactDetails.NewsYear = "2021";
                contactDetails.NewsHeader = "Legend announces the establishment of its new office in Karachi, Pakistan";
                contactDetails.NewsDate = "27 October 2021";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N21/NewOfficeKarachi.webp' style='width:50%;' class='responsive'>";
                contactDetails.NewsText = "<p class='obiz'> Legend is proud to announce another significant milestone with the inauguration of our new joint venture company, LEGEND LOGISTICS PAKISTAN (PRIVATE) LIMITED in Karachi, " +
                "Pakistan.<br><br> LEGEND PAKISTAN is a joint venture with BILAL ASSOCIATES PRIVATE LIMITED, a leading 3rd party logistics provider in Pakistan.<br><br> The establishment of LEGEND PAKISTAN is part of our business " +
                "strategy to expand and grow our presence in the market and to better serve our customers in the India Subcontinent region. LEGEND PAKISTAN provides logistics solutions for all types of freight, including bulk liquid" +
                "chemicals, consumer perishables, and dry commodities.<br><br> The opening ceremony was marked by the presence of honorable guests including Capt Rashid Jameel CEO (SAPT), Mr Changsu Kim CEO (KICT) and respected " +
                "commercial and finance teams of terminals.<br><br> We thank all our customers, partners and employees for their continued support throughout this journey.<br><br> For any business enquiries, please contact<br><br>" +
                "<a href='mailto:info.pakistan@legendasia.com' class='anchorStyling'>info.pakistan@legendasia.com</a><br>" +
                "<a href='mailto:Ramzan.ali@legendasia.com' class='anchorStyling'>Ramzan.ali@legendasia.com</a></p><br>";
            }
            if (ID == "Jan0122")
            {
                contactDetails.IDNews = "Jan0122";
                contactDetails.NewsYear = "2022";
                contactDetails.NewsHeader = "Announcement of company name change";
                contactDetails.NewsDate = "01 January 2022";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N22/LegendTanklogo.webp' style='width:40%;' class='responsive'>";
                contactDetails.NewsText = "<p class='obiz'> We are pleased to announce that Legend Logistics (Asia) Pte Ltd, a wholly-owned subsidiary of Legend Logistics Limited, has been rebranded to Legend Tank Logistics Pte Ltd effective " +
                "01 January 2022. This rebranding exercise reflects the focus of its business activities on bulk liquid logistics and depot management.</p>" +
                "<p class='obiz'> The new name symbolizes our dedication to the bulk liquid logistics industry, providing solutions to food-grade, oleochemicals, petrochemical, and pharmaceutical products.</p>" +
                "<p class='obiz'> Other than the trading name, all details remain unchanged.</p>" +
                "<p class='obiz'> As always, Legend endeavors towards providing exceptional customer service. We thank you and look forward to your continued support as we embark on this exciting phase of progress.</p><br>";
            }
            if (ID == "Feb0122")
            {
                contactDetails.IDNews = "Feb0122";
                contactDetails.NewsYear = "2022";
                contactDetails.NewsHeader = "Legend is proud to have been awarded ISO 22000:2018 and ISO 14001:2015 accreditations";
                contactDetails.NewsDate = "01 February 2022";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N22/ISO14001.webp' alt='' style='width: 20%;height: 10%;margin:auto;'><img src='../Content/images/AllNews/N22/QAI_ISO 22000.webp' alt='' style='width: 13%;height: 7%;margin:auto;padding-left: 10px;'>";
                contactDetails.NewsText = "<p class='obiz'> Legend is delighted to have been awarded ISO 22000:2018 and ISO 14001:2015 accreditations. These internationally recognised standards ensure that our products and services meet our " +
                "customers&apos; needs through a food safety management system and demonstrate our commitment to sustainability through an environment management system.</p>" +
                "<p class='obiz'> ISO 22000:2018 is an international standard designed to ensure food supply chain safety worldwide, enabling organisations to demonstrate their ability to control food safety hazards. In addition to our existing " +
                "ISO 9001:2015 certification, ISO 22000:2018 accreditation demonstrates Legend&apos;s ability to consistently provide high-quality services that meet food safety, HACCP principles, and regulatory requirements.</p>" +
                "<p class='obiz'> ISO 14001:2015 is the international standard that specifies requirements for an effective environmental management system (EMS). Through this accreditation, Legend reinforces its commitment to sustainability.</p>" +
                "<p class='obiz'> 'These certifications demonstrate our strong commitment to delivering high quality, safety and sustainability in all areas of our business. We are proud of our ISO team for achieving this milestone 'says CK Than, " +
                "CEO of Legend Logistics Group.</p><br>";
            }
            if (ID == "Feb2522")
            {
                contactDetails.IDNews = "Feb2522";
                contactDetails.NewsYear = "2022";
                contactDetails.NewsHeader = "Legend expands its global presence with opening of Dubai office";
                contactDetails.NewsDate = "25 February 2022";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N22/Dubai.webp' alt='' style='width: 50%;margin:auto;'/>";
                contactDetails.NewsText = "<p class='obiz'> Legend is pleased to announce the opening of our new office in Dubai, LEGEND SHIPPING LLC. The expansion into Dubai is in line with our goal of strengthening our global presence " +
                "and providing a strategic base to serve customers in the Middle East and North Africa regions.</p>" +
                "<p class='obiz'>&quot;This is an important step for Legend Group in expanding our presence into the Middle East. The Dubai office will enable us to provide better and more efficient logistics services to our customers and " +
                "help us build strong relationships with key players in the region.&quot; says Mr. CK Than, founder and CEO of Legend Group.</p>" +
                "<p class='obiz'> LEGEND SHIPPING LLC provides logistics solutions for all types of freight, including bulk liquid chemicals, consumer perishables, and dry commodities as well as agency services for container operators. " +
                "The new office is located at 104 A4, 1st Floor, Wing A2, Gulf Towers, Near K.M. Trading, Oud Metha, Dubai, U.A.E.</p><br>";
            }
            if (ID == "Apr1922")
            {
                contactDetails.IDNews = "Apr1922";
                contactDetails.NewsYear = "2022";
                contactDetails.NewsHeader = "Celebrating Legend Group’s 10th Anniversary - a message from the Group CEO";
                contactDetails.NewsDate = "19 April 2022";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N22/10AniLogo.webp' alt='' style='width: 30%;margin:auto;'>";
                contactDetails.NewsText = "<p class='obiz'> I am extremely proud to be marking Legend Group&apos;s 10th Anniversary this year.</p>" +
                "<p class='obiz'> As we celebrate this significant milestone, we reflect on how Legend has evolved over the past decade.</p>" +
                "<p class='obiz'> Founded in 2012 as a domestic freight forwarder, Legend has since grown into a global integrated specialised logistics provider.  Throughout the years, we have accelerated our growth by diversifying " +
                "our services and expanding our reach into new regions and niche markets to provide clients with reliable, cost-effective and one-stop logistics solutions through our 4 business segments: Legend Tank, Legend Carrier, " +
                "Legend Specialised and Legend Global.</p>" +
                "<p class='obiz'> •\tLegend Tank has steadily grown its fleet of tank containers making us now one of the largest tank container operators in Asia.<br> •" +
                "\tOperating on a hub-and-spoke mode, Legend Carrier offers breakbulk and marine logistics, dedicated liner and regional feeder services in emerging markets. <br> •" +
                "\tTo build up a strong track record and reputation in Specialised Logistics, we strategically established our Specialised Trucking business in Australia in 2018 and Yacht Transport division in USA in 2021.<br> " +
                "•\tOverseas expansion has always been one of our top agenda as it&apos;s critical to our growth. Today, we have expanded our footprints into four continents, operating in 12 countries with 15 regional offices and " +
                "over 400 employees. Legend Global represents our Tank, Carrier and Specialised Logistics divisions and provides a broad range of value-added services that enable us to deliver a fully integrated logistics solution. <br></p>" +
                "<p class='obiz'> I am immensely proud of what we have achieved over the past ten years and I would like to take this opportunity to thank all our dedicated employees, customers, investors and business partners for " +
                "their support and trust in us. We would not have been able to reach this milestone without you. </p>" +
                "<p class='obiz'> Looking ahead, we will continue to explore new growth areas and invest in new capabilities and technologies to serve a broader clientele from various industries and ensure we remain at the forefront of " +
                "the logistics industry.</p>" +
                "<p class='obiz'> I am confident that Legend will continue to build upon its success with a stronger commitment and a more sustainable and innovative approach in the years to come.</p>" +
                "<p class='obiz'> Happy 10th Anniversary and here&apos;s to many more!</p>" +
                "<p class='obiz'> CK Than<br> Group CEO<br> Legend Logistics Group</p><br>";
            }
            if (ID == "Jul2822")
            {
                contactDetails.IDNews = "Jul2822";
                contactDetails.NewsYear = "2022";
                contactDetails.NewsHeader = "Legend Group CEO CK Than officially inaugurates the opening of Legend’s new offices in Mumbai and Dubai";
                contactDetails.NewsDate = "28 July 2022";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N22/1.webp' alt='' style='width: 33%;margin:auto;'>" +
                                             "<img src='../Content/images/AllNews/N22/2.webp' alt='' style='width: 33%;margin:auto;'>" +
                                             "<img src='../Content/images/AllNews/N22/4.webp' alt='' style='width: 33%;margin:auto;'>";
                contactDetails.NewsText = "<p class='obiz'> Legend Mumbai is honored to have CK Than, our Group CEO, to officially inaugurate the opening of our new offices in Mumbai and Dubai.</p>" +
                "<p class='obiz'> Since its inception in 2017, Legend Mumbai has expanded its service coverage across the India Subcon (ISC) and Middle East regions and grown to a strong team of over 100 staff. " +
                "In 2021, Legend Mumbai opened its first tank container depot in Nhava Sheva to improve the efficiency of its services and to provide value-added solutions to its customers such as tank washing, " +
                "periodic checks, and storage. Earlier this year, the India team established Dubai office to capitalize on the business opportunities in the Middle East and North Africa regions.</p>" +
                "<p class='obiz'>&quot;I am glad to see the rapid growth of our Mumbai office, building a strong team to lead our ISC and Middle East development. Since then, Legend has grown to be the leading operator in the region. " +
                "I&apos;m very proud of the team&apos;s achievements and excited for what lies ahead this year.&quot; says CK during the inauguration ceremony.</p>" +
                "<p class='obiz'> CK and Mumbai Team also welcomed the Regional Directors of Enterprise Singapore based in India, Denise Tan and Kar Meng Teoh, where they discussed Legend’s regional expansion plans including " +
                "expanding our presence throughout India and building infrastructures to support the growth, i.e. container freight stations, tank depot and warehousing facilities. These are in line with Legend’s growth strategy " +
                "to strengthen our position and become a leading integrated specialized logistics provider in India. Enterprise Singapore shared excitement about our plans and is keen to provide business support to drive our growth " +
                "and competitiveness in the region. After the meeting, CK and Mumbai team toured Enterprise Singapore representatives to Legend’s tank depot in Nhava Sheva for a first-hand look at how tanks are being cleaned and repaired.</p><br>";
            }
            if (ID == "Sep1322")
            {
                contactDetails.IDNews = "Sep1322";
                contactDetails.NewsYear = "2022";
                contactDetails.NewsHeader = "Legend Group launches Fintech subsidiary with efficient trade finance for global supply chain to address the interest rate hike";
                contactDetails.NewsDate = "13 September 2022";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N22/bradcam21.webp' alt='' style='width: 50%;margin:auto;'>";
                contactDetails.NewsText = "<p class='obiz'><a href='../Content/documents/13 Sep 22_Press_Release.pdf' name='#3' style='color:#183682;font-weight:bold;' download=''>Download Press Release</a></p>" +
                "<p class='obiz'> LEGEND Group is excited to announce the launch of LEGEND Fintech and its maiden service – TRADEGO.</p>" +
                "<p class='obiz'> TradeGo is a trade finance service that reduces the inventory carrying cost, finance cost and time to secure finance for LEGEND Logistics’ customers. TradeGo is unique because it marks the " +
                "completion of service scopes for a supply chain, with physical, informational, and financial flows under one roof. The TradeGo service will officially be available for shippers and consignees on 15th September 2022.</p>" +
                "<p class='obiz'> Supply chain disruption is always dangerous to 332.99 million small and mid-size (SME) global manufacturers and traders. LEGEND Logistics ships commodity raw materials from international suppliers to " +
                "these SMEs, enabling them to produce in Asia for the world. In current log-jam uncertainty and increasing interest rate, the SMEs are experiencing more significant supply chain stress and escalating cost.</p>" +
                "<p class='obiz'> Being an integral partner of the SMEs operation flow, LEGEND Logistics has an intimate understanding of the demand & supply conditions, amassing years of operational data of the supply chain, " +
                "and is in control of the physical commodity movements that generate such data. Therefore, the condition is ripped for the creation of TRADEGO with the establishment of LEGEND Fintech.</p>" +
                "<p class='obiz'> LEGEND Fintech established the bankability of the SME traders and consignees based on historical data, working closely with financiers to provide the much-needed trade finance to their consignments. " +
                "The bankability established in TradeGo enables LEGEND Fintech&apos;s customers to obtain trade finance fast, avoid the log-jam and continue building their creditworthiness.</p>" +
                "<p class='obiz'> &quot;TradeGo is a much-needed product for SME traders, who are integral to the Asian economy survival after the pandemic and into the financial crisis.&quot; said Dr Alex Lin, CEO of LEGEND " +
                "Fintech. &quot;With TradeGo, we&apos;ll serve LEGEND Logistics&apos; current ecosystem and expand to more SMEs as we progress.&quot;</p>" +
                "<p class='obiz'><u>About LEGEND GROUP</u></p>" +
                "<p class='obiz'> Legend Group, headquartered in Singapore with presence in Asia, Oceania, Europe and North America, is an integrated specialised logistics provider. It is one of the most diversified transportation " +
                "companies in Asia and is a one-stop logistics provider for heavy haulage, bulk liquid, dry commodities, perishable products and oversized cargos.</p>" +
                "<p class='obiz'> As an asset-based company with global deployment, Legend invests in its own fleet of purpose-built vessel, tank container, dry and reefer containers, heavy haulage and out-of-gauge transport equipment " +
                "to provide reliable logistics solutions and value-add customer’s operations. <!-- For additional information, please visit Legend&apos;s website at <a href='www.legendasia.com' style='color:blue; font-size: 14px;'>" +
                "www.legendasia.com</a> --></p><br>";
            }
            if (ID == "Oct2622")
            {
                contactDetails.IDNews = "Oct2622";
                contactDetails.NewsYear = "2022";
                contactDetails.NewsHeader = "Legend opens new branch office in Jakarta, Indonesia";
                contactDetails.NewsDate = "26 October 2022";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N22/Jakarta1.webp' alt='' style='width: 50%;margin:auto;'>" +
                                             "<img src='../Content/images/AllNews/N22/Jakarta2.webp' alt='' style='width: 50%;margin:auto;'>";
                contactDetails.NewsText = "<p class='obiz'> Legend Group is proud to announce the opening of its branch office in Jakarta, Indonesia.</p>" +
                "<p class='obiz'> Since its inception in 2020, PT Legend Logistik Indonesia, a wholly-owned subsidiary of Legend Group, has continued to expand its capabilities and venture into new businesses to service our customers across Indonesia. " +
                "Through our acquisition of iG Logistics Group in 2020 and our continuous introduction of new feeder services such as Kuala Tanjung to Port Klang, Batam to Singapore, Bintan to Singapore, and Pasir Gudang to Singapore using our " +
                "purpose-built vessels, we are strategically positioned to offer unique multimodal logistics solutions and door-to-door logistics services to various industries at emerging niche ports throughout the region.</p>" +
                "<p class='obiz'> Together with our other offices in Medan, Bintan and Batam, Legend will continue to establish and develop a strong sales and distribution network in Indonesia and pursue our growth as a Regional Container " +
                "Operator and Breakbulk Carrier, further stamping our presence in Asia.</p>" +
                "<p class='obiz'> The branch manager for Jakarta office is Mr. Joko Soptono, who has over 30 years of experience in the shipping and logistics industry. The new office is located at Graha Kirana Building 12th floor #1201 Jl. " +
                "Yos Sudarso No. 88, Sunter Jay, Tanjung Priok, Jakarta Utara 14350, Indonesia.</p><br>";
            }
            if (ID == "Nov2422")
            {
                contactDetails.IDNews = "Nov2422";
                contactDetails.NewsYear = "2022";
                contactDetails.NewsHeader = "Legend Logistics Group wins the Enterprise 50 Award 2022";
                contactDetails.NewsDate = "24 November 2022";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N22/e50OG.webp' style='width:50%;' class='responsive'>";
                contactDetails.NewsText = "<p class='obiz'> Legend Logistics Group was honoured to receive the prestigious Enterprise 50 Award (E50) 2022. Legend ranked 11th among the top 50 privately-held local outstanding companies in Singapore. It is Legend’s second year receiving the E50 Award after ranking 12th in the E50 Award 2020.</p>" +
                "<p class='obiz'> The E50 2022 Gala Dinner & Award Ceremony was held last 23 November 2022 at the Resorts World Convention Center.</p>" +
                "<p class='obiz'> Legend Logistics Group extends its heartfelt appreciation and gratitude to its clients, suppliers, partners, and employees for making this award possible.</p>" +
                "<p class='obiz'> Established in 1995, the E50 Award seeks to recognise the 50 most enterprising local, privately-held companies who have contributed to the economic development of Singapore both locally and abroad. It is jointly organised by The Business Times and KPMG in Singapore, supported by Enterprise Singapore, the Singapore Business Federation and the Singapore Exchange, and is sponsored by OCBC Bank.</p><br>";
            }
            if (ID == "Nov2922")
            {
                contactDetails.IDNews = "Nov2922";
                contactDetails.NewsYear = "2022";
                contactDetails.NewsHeader = "Legend Logistics Australia has won two tenders on the AUD 15.8 billion North East Link Project";
                contactDetails.NewsDate = "29 November 2022";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N22/Tenders.webp' style='width:50%;' class='responsive'>";
                contactDetails.NewsText = "<p class='obiz'> Legend Logistics Australia is excited to announce that we have been successful in winning the two tenders on the AUD 15.8 billion North East link project. This will keep the Legend " +
                "Melbourne tipper team busy for the next five years. We are honored to be one of the chosen logistics providers on this Spark built project.</p>" +
                "<p class='obiz'> Victoria&apos;s longest twin road tunnels will fix the missing link in Melbourne&apos;s freeway network, complete the Ring Road in Greensborough, overhaul the Eastern Freeway, build Melbourne&apos;s first " +
                "dedicated busway and more than 34km of walking and cycling paths in 16 suburbs.</p>" +
                "<p class='obiz'> With half a million Victorians living within 2km of a planned interchange, this massive program of work will bring the road, bus and bike network together and change the way people move around Melbourne.</p><br>";
            }
            if (ID == "Dec0222")
            {
                contactDetails.IDNews = "Dec0222";
                contactDetails.NewsYear = "2022";
                contactDetails.NewsHeader = "Legend Logistics Group celebrates its 10th Anniversary Dinner & Dance";
                contactDetails.NewsDate = "02 December 2022";
                contactDetails.NewsIMGPath = "<video loop autoplay playsinline controls='true' id='myVideo' source src='../Content/video/LegendDND2022.mp4' type='video/mp4'></video>";
                contactDetails.NewsText = "<p class='obiz'>On 02 December 2022, Legend Logistics Group celebrated its 10th Anniversary Dinner & Dance with an Around the World theme." +
                "The event was held at Pan Pacific Singapore and was attended by Legend colleagues from all offices.</p>" +
                "<p class='obiz'> The Legend team had a momentous night by reminiscing back on our humble beginnings, celebrating the company milestones over the last ten years, and confidently blazing the path as we continuously march to progress. Furthermore, everyone dressed to impress as we finally met our colleagues from overseas offices after two years. Indeed, it was a night filled with joy and glamour!</p>" +
                "<p class='obiz'> A big thank you goes out to everyone who attended and helped make this such a memorable night. We're looking forward to many more years of continued success with all of our amazing employees by our side.</p><br>";
            }
            if (ID == "Dec0922")
            {
                contactDetails.IDNews = "Dec0922";
                contactDetails.NewsYear = "2022";
                contactDetails.NewsHeader = "Legend Logistics Australia opens Perth depot ahead of national expansion";
                contactDetails.NewsDate = "09 December 2022";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N22/Legendlogisticsopensperthdepot.webp' style='width:50%;' class='responsive'>";
                contactDetails.NewsText = "<p class='obiz'> Legend Logistics Australia has taken a major step forward in its national expansion plans with the opening of its first depot in Welshpool, Perth. The new site marks the first " +
                "official presence of Legend Logistics outside Melbourne, where its head office is based.</p>" +
                "<p class='obiz'> According to Managing Director Troy Eiken, &quot;Western Australia has been identified as a crucial growth segment, which has prompted further investments in equipment and personnel.&quot;</p>" +
                "<p class='obiz'> Five prime movers have been recently acquired for the location, including four Western Star 4800s which are currently in operation, and an additional Western Star 4900 en route. At present, the new depot " +
                "is servicing some minor contracts as it consolidates the linehaul business before venturing into the Pilbara where there is an ongoing demand for commercial vehicle fleets in the mining and gas segments.</p>" +
                "<p class='obiz'> &quot;We’re looking to grow that in the near future with larger contracts in the next year,&quot; said Troy Eiken.</p>" +
                "<p class='obiz'> With the Perth office up and running, the next phase of the plan is for Legend Logistics Australia to establish a depot in Adelaide early next year ahead of a likely expansion into Brisbane by Q4.</p>" +
                "<p class='obiz'> Currently, Legend Logistics Australia employs 130 staff, having doubled its workforce in the last 12 months alone. In that corresponding period, the fleet has also doubled, having 40 prime movers now with " +
                "more on order.</p><br>";
            }
            if (ID == "Jan1723")
            {
                contactDetails.IDNews = "Jan1723";
                contactDetails.NewsYear = "2023";
                contactDetails.NewsHeader = "Legend Logistics Group recognises as one of Singapore’s Top 100 Fastest Growing Companies in 2023 ";
                contactDetails.NewsDate = "17 January 2023";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N19/LegendGrouplogo.webp' style='width:50%;' class='responsive'>";
                contactDetails.NewsText = "<p class='obiz'> We are delighted to announce that Legend Logistics Limited has been recognised as one of the Top 100 Singapore&apos;s Fastest Growing Companies in the fifth edition by The Straits " +
                "Times and Germany-based global research firm Statista.</p>" +
                "<p class='obiz'> Singapore&apos;s Fastest Growing Companies is a list of 100 local businesses that achieved markedly high revenue growth between 2018 and 2021. Out of 100 local firms, Legend ranked 22nd with an impressive " +
                "absolute growth rate of 591.8% and a compound annual growth rate (CAGR) of 90.54% from 2018 to 2021. In addition, Legend&apos;s revenue increased from SGD 17,9175,798 in 2018 to SGD 122,753,654 in 2021 and the number " +
                "of employees grew from 34 in 2018 to 364 in 2021.</p>" +
                "<p class='obiz'>&quot;Legend has seen remarkable growth in the past years and we&apos;re incredibly proud of our achievements. We would like to extend our heartfelt thanks to our employees, customers, and partners for the " +
                "continued trust and support. We look forward to new opportunities and greater success in 2023!&quot; said CK Than, CEO of Legend Group.</p>" +
                "<p class='obiz'> Click <a id='IMP' href= 'https://www.straitstimes.com/fastest-growing-companies-2023'>here</a> to view the list of winners and the rankings.</p><br>";
            }
            if (ID == "Jan2523")
            {
                contactDetails.IDNews = "Jan2523";
                contactDetails.NewsYear = "2023";
                contactDetails.NewsHeader = "Legend India opens its second tank container depot in Kandla";
                contactDetails.NewsDate = "25 January 2023";
                contactDetails.NewsIMGPath = "<video loop autoplay playsinline controls='true' id='myVideo' source src='../Content/video/LegendKandla.mp4' type='video/mp4'></video>";
                contactDetails.NewsText = "<p class='obiz'> Legend Group is proud to expand our footprint in India with the opening of Legend Container Depot in Kandla on 25th January 2023. This marks our second depot in India after " +
                "successfully operating our tank depot in Nhava Sheva in January 2021.</p>" +
                "<p class='obiz'> Strategically located just 12 kilometers from Kandla port and 65 kilometers from Mundra port, this 5-acre (20,000 sqm) facility provides quick access to two of India’s busiest ports with a handling " +
                "capacity of 1,200 TEUs. </p>" +
                "<p class='obiz'> The establishment of this depot is part of Legend’s strategic plan to further expand our services to Northern India territory and capture the opportunities in this rapidly growing market. " +
                "Additionally, it allows our customers in this region to benefit from greater flexibility, cost savings, and efficiency by gaining quick access to our solutions.</p><br>";
            }
            if (ID == "Jan3023")
            {
                contactDetails.IDNews = "Jan3023";
                contactDetails.NewsYear = "2023";
                contactDetails.NewsHeader = "Legend expands its global footprint with new office in Seoul, South Korea";
                contactDetails.NewsDate = "30 January 2023";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N23/Seoul1.webp' alt='' style='width: 33%;margin:auto;'>" +
                                             "<img src='../Content/images/AllNews/N23/Seoul2.webp' alt='' style='width: 33%;margin:auto;'>" +
                                             "<img src='../Content/images/AllNews/N23/Seoul3.webp' alt='' style='width: 33%;margin:auto;'>";
                contactDetails.NewsText = "<p class='obiz'> Legend Group is proud to mark another milestone in its global expansion by opening its new office in Seoul, South Korea. The new office signifies Legend&apos;s continued global growth " +
                "and development.</p>" +
                "<p class='obiz'>This strategic expansion further entrenches our mission to effectively serve our customers in the region and pan-Asia markets with reliable, tailored and comprehensive logistics solutions. " +
                "In addition, this will enable us to tap into the region&apos;s vast opportunities and growth potential.</p>" +
                "<p class='obiz'>Legend Seoul office offers logistics and shipping solutions for all types of freight including bulk liquid chemicals, dry and perishable commodities, project and oversized cargos. The new office is located at " +
                "NK Building 13th Floor, Bongeunsaro 306, Gangnamgu, Seoul, and led by Francisco Roh, General Manager.</p><br>";
            }
            if (ID == "Feb1023")
            {
                contactDetails.IDNews = "Feb1023";
                contactDetails.NewsYear = "2023";
                contactDetails.NewsHeader = "Legend launches its domestic trucking services in Dubai";
                contactDetails.NewsDate = "10 February 2023";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N23/DubaiTrucks1.webp' alt='' style='width: 33%;margin:auto;'>" +
                                             "<img src='../Content/images/AllNews/N23/DubaiTrucks2.webp' alt='' style='width: 33%;margin:auto;'>" +
                                             "<img src='../Content/images/AllNews/N23/DubaiTrucks3.webp' alt='' style='width: 33%;margin:auto;'>";
                contactDetails.NewsText = "<p class='obiz'> Legend Shipping LLC, a wholly-owned subsidiary of Legend Group (&quot;Legend&quot;), is pleased to announce the launch of its domestic trucking services in Dubai. " +
                "This exciting new venture will strengthen and complement Legend’s core businesses, which are the ISO tanks and dry containers, providing integrated logistics and door-to-door solutions to our esteemed clients within the region.</p>" +
                "<p class='obiz'> We are progressively building up our trucking fleet and expanding our routes to multiple ports, storage terminals, and refineries across the Middle East region to deliver high-quality complementary services along " +
                "with our own ISO tanks and dry containers.</p>" +
                "<p class='obiz'> &quot;We are very excited to launch our domestic trucking services in Dubai. We believe this new venture will enable us to expand our reach in the region and help us better serve existing customers, as well as " +
                "new ones.&quot; said Dennis Wong, Deputy CEO of Legend Group.</p>" +
                "<p class='obiz'> Legend will expand our domestic trucking service throughout our entire network of offices to further support our ISO tanks and dry container businesses and better serve our clients globally.</p><br>";
            }
            if (ID == "Feb2823")
            {
                contactDetails.IDNews = "Feb2823";
                contactDetails.NewsYear = "2023";
                contactDetails.NewsHeader = "Legend completes the acquisition of Budgetcars Pte Ltd and its sister company, CFI Transport Pte Ltd";
                contactDetails.NewsDate = "28 February 2023";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N23/Budgetimage.webp' alt='' style='width: 45%;margin:auto;'>" +
                                             "<img src='../Content/images/AllNews/N23/Budgetimage2.webp' alt='' style='width: 54%;margin:auto;'>";
                contactDetails.NewsText = "<p class='obiz'> Legend Logistics Limited and its subsidiaries (collectively &quot;Legend Group&quot;) are pleased to announce that our subsidiary Legend Integrated Logistics Pte Ltd (&quot;Legend Integrated&quot;) " +
                "has completed the acquisition of Budgetcars Pte Ltd and its sister company, CFI Transport Pte Ltd (collectively known as &quot;BGC&quot;), leading last mile delivery companies that specialise in fast and reliable delivery services. " +
                "This acquisition marks a significant milestone for the Group as we continue to expand our reach and capabilities in the logistics industry.</p>" +
                "<p class='obiz'>Founded in 2016, BGC has grown to become the largest wholly-owned asset last mile delivery company in Singapore, boasting an impressive fleet of 105 vehicles consisting of vans, trucks, prime movers and trailers. " +
                "BGC&apos;s strong collaboration with e-commerce and wholesale international industry giants allows Legend Group to leverage and develop our partnerships with these key industry leaders.</p>" +
                "<p class='obiz'>The acquisition of BGC allows us to enhance our first and last mile delivery capabilities, expand into the business-to-consumer market, and offer a more comprehensive suite of services to our customers and partners, " +
                "creating a truly integrated logistics ecosystem and solidifying our position as a leader in the industry.</p>" +
                "<p class='obiz'>Legend Group is excited about the potential and opportunities this acquisition presents for continued growth and expansion, especially in the Electric Vehicle (EV) segment. Just recently, Legend Group took a big step " +
                "towards sustainability with our recent purchase of 20 new electric vans, aiming to gradually replace our entire fleet and fully adopt EVs to develop and promote a more sustainable first and last mile delivery service in line with " +
                "the Singapore Green Plan 2030.</p>" +
                "<p class='obiz'>We are committed to providing exceptional service and value to our customers, and this acquisition is just one example of our dedication to that goal.</p><br>";
            }
            if (ID == "Apr1123")
            {
                contactDetails.IDNews = "Apr1123";
                contactDetails.NewsYear = "2023";
                contactDetails.NewsHeader = "Legend expands with new offices in Mundra, India and Qingdao, China";
                contactDetails.NewsDate = "11 April 2023";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N23/Mundra.webp' alt='' style='width: 50%;margin:auto;'>" +
                                             "<img src='../Content/images/AllNews/N23/Qingdao.webp' alt='' style='width: 50%;margin:auto;'>";
                contactDetails.NewsText = "<p class='obiz'> We are delighted to announce that our new offices in Mundra, India and Qingdao, China have officially commenced operations effective 01 April 2023. This significant expansion allows us to " +
                "further extend our global footprint and strengthen our presence in the bustling markets of Asia. Both offices are fully equipped to provide reliable, integrated specialised logistics for bulk liquids, dry commodities, general cargos, " +
                "and over-dimensional cargos.</p>" +
                "<p class='obiz' style='font-weight:bold;'> Mundra, India </p>" +
                "<p class='obiz'>With access to major road, rail, and shipping routes, our Mundra office is well-equipped to provide seamless connections for our clients' supply chain needs across India and internationally. Strategically located near " +
                "one of India's busiest ports, our Mundra branch office will provide us diverse opportunities to expand our logistics services and establish a strong foothold across the region.</p>" +
                "<p class='obiz' style='font-weight:bold;'> Qingdao, China </p>" +
                "<p class='obiz'>Qingdao, renowned for its thriving trade and transportation infrastructure, serves as a gateway to China's vast domestic market and international trade routes. Our new presence in Qingdao will enable us to tap into the " +
                "city's extensive shipping and logistics network, offering clients efficient, comprehensive logistics solutions.</p>" +
                "<p class='obiz'>Our Qingdao office is located at Room 3108, China Resources Tower A, No. 6, Shandong Road, Shinan District, Qingdao, China.</p>" +
                "<p class='obiz'>At Legend, we are committed to delivering reliable and cost-effective integrated specialised logistics solutions to our clients. The establishment of these new offices is a testament to our dedication to serving the " +
                "evolving needs of our global customers.</p>" +
                "<p class='obiz'>Feel free to contact our local teams in Mundra and Qingdao for any enquiries.</p>" +
                "<p class='obiz'><strong>Mundra Office</strong><br> Ketan Rathod<br> General Manager<br><a href='mailto:ketan.rathod@legendasia.com'>ketan.rathod@legendasia.com</a><br></p>" +
                "<p class='obiz'><strong>Kandla Tank Depot</strong><br> Rahul Bhangre<br> Head, South West Asia and Africa region<br>Tank Container Division<br><a href='mailto:rahul.b@legendasia.com'>rahul.b@legendasia.com</a><br></p>" +
                "<p class='obiz'><strong>Qingdao Office</strong><br>Cherub Yu<br>Branch Manager<br><a href='mailto:cherub.yu@legendasia.com'>cherub.yu@legendasia.com</a><br></p><br>";
            }
            if (ID == "May1323")
            {
                contactDetails.IDNews = "May1323";
                contactDetails.NewsYear = "2023";
                contactDetails.NewsHeader = "Legend transports the first consignment of live broiler chickens from Bintan farm to Singapore Poultry Hub";
                contactDetails.NewsDate = "13 May 2023";
                contactDetails.NewsIMGPath = "<video loop autoplay playsinline controls='true' id='myVideo' source src='../Content/video/Menit.mp4' type='video/mp4'></video>";
                contactDetails.NewsText = "<p class='obiz'>After several months of meticulous planning and close collaboration with regulatory agencies and authorities, Legend has successfully executed the transportation of the first consignment of live " +
                "broiler chickens from a Bintan farm in Indonesia to Singapore Poultry Hub on 13th May 2023.</p>" +
                "<p class='obiz'>This project demonstrates Legend's capability to customize, optimize and invest in our assets to provide safe, reliable and cost-effective integrated logistics tailored to our client's requirements.</p>" +
                "<p class='obiz'>We extend our heartfelt gratitude to our valued clients, partners, and stakeholders who have supported us throughout this journey. Together, we look forward to embarking on more groundbreaking projects and " +
                "playing a pivotal role in shaping the future of the logistics landscape.</p><br>";
            }
            if (ID == "Jun2123")
            {
                contactDetails.IDNews = "Jun2123";
                contactDetails.NewsYear = "2023";
                contactDetails.NewsHeader = "PT Legend Marine Indonesia opens its new office in Batam";
                contactDetails.NewsDate = "21 June 2023";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N23/Batam.jpeg' style='width:50%;' class='responsive'>";
                contactDetails.NewsText = "<p class='obiz'>On 21 June 2023, PT Legend Marine Indonesia, a wholly owned subsidiary of Legend Group, proudly inaugurated its new office located at Komplek Ruko Batam Central Park Blok B No 8D, Tanjung Uma, " +
                "Lubuk Baja Kota Batam, Kepulauan Riau. This momentous occasion was officiated by Dwi Ervianti, the Branch Manager, accompanied by the senior management of Legend Group.</p>" +
                "<p class='obiz'>The opening of this new office marks a significant milestone in PT Legend Marine Indonesia's journey, emphasizing the company's unwavering commitment to the Indonesian market and its continuous pursuit of excellence. " +
                "The company remains focused on its core mission of providing reliable and efficient feeder and door-to-door services in Batam</p><br>";
            }
            if (ID == "Jun2823")
            {
                contactDetails.IDNews = "Jun2823";
                contactDetails.NewsYear = "2023";
                contactDetails.NewsHeader = "Legend Logistics Group names as one of Singapore’s Best Managed Companies 2023";
                contactDetails.NewsDate = " 28 June 2023";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N23/BestManaged1.jpeg' alt='' style='width: 65%;margin:auto;'>" +
                                             "<img src='../Content/images/AllNews/N23/BestManaged2.jpeg' alt='' style='width: 26%;margin:auto;'>";
                contactDetails.NewsText = "<p class='obiz'>Legend Group is honored to be awarded as one of Singapore's Best Managed Companies 2023 by Deloitte Singapore. The Awards Program recognises 10 exceptional private businesses in " +
                "Singapore for their organisational success and contributions to their industry and the economy. The Awards Ceremony & Gala Dinner was held last 28 June 2023 at Singapore Marriott Tang Plaza Hotel.</p>" +
                "<p class='obiz'>The feeling is absolutely humbling and jubilant to be awarded as a first-time winner of Singapore's Best Managed Companies 2023. It reflects our people's dedication and strong commitment attest to our company's " +
                "zealous cycle of constant drive for business excellence. This win has great significance to us as it aligns us with Deloitte in conducting business with high integrity, quality, and levels of professionalism through shared values " +
                "and global principles of business conduct. said Mr. Dennis Wong, Deputy CEO of Legend Group.</p>" +
                "<p class='obiz'>Legend Group would like to express our heartfelt gratitude to our employees, partners, and clients for their continuous support and trust in our organization. This achievement would not have been possible without " +
                "their invaluable contributions.</p><br>";
            }
            if (ID == "Jul0723")
            {
                contactDetails.IDNews = "Jul0723";
                contactDetails.NewsYear = "2023";
                contactDetails.NewsHeader = "Legend Group expands into North America";
                contactDetails.NewsDate = "07 July 2023";
                contactDetails.NewsIMGPath = "<img src='../Content/images/AllNews/N23/HoustonBuilding.jpg' alt='' style='width: 65%;margin:auto;'>";
                contactDetails.NewsText = "<p class='obiz' style='font-style:italic;'>This new office opening underscores Legend's commitment to growing in North America and delivering reliable and " +
                "cost-effective integrated specialised logistics solutions to its clients.</p><p class='obiz'>Legend Group, a renowned global leader in integrated specialised logistics," +
                " today announced its expansion into North America with the opening of a new office in Houston, Texas.</p>" +
                "<p class='obiz'>Ruben Hofland, who has 15 years of experience in " +
                "the industry, including six years in the USA, will lead the Houston office as the General Manager of Legend Logistics (USA) Inc. With his extensive knowledge and expertise, " +
                "Mr. Hofland will ensure a seamless transition for Legend as it expands into North America.</p>" +
                "<p class='obiz'>The Houston office is located at 19500 State Highway 249, St. 227, " +
                "Houston, Texas 77070. The choice of location was strategic, as Houston is a significant business hub in the USA and an excellent location for Legend to expand its services across " +
                "North America.</p><p class='obiz'>The establishment of Houston office marks a significant milestone for Legend, demonstrating the Group’s commitment to growing and strengthening its " +
                "position as a global integrated specialised logistics provider. Furthermore, Legend’s strategic presence in Houston is poised to take advantage of the significant opportunities presented " +
                "by the North American market and continue to deliver exceptional services to its clients.</p><br>";
            }
            if (ID == "Jul1024")
            {
                contactDetails.IDNews = "Jul1024";
                contactDetails.NewsYear = "2024";
                contactDetails.NewsHeader = "Legend Logistics Group marks new era with new brand identity, Regent Group ";
                contactDetails.NewsDate = "10 July 2024";
                contactDetails.NewsIMGPath = "<img src='../Content/images/RegentVessel/RegentGroup.png' alt='' style='width: 40%;margin:auto;' class='mb-4'>";
                contactDetails.NewsText =
                    "<p class='obiz'>For the last decade, Legend Logistics Limited has provided comprehensive logistics solutions to clients globally through two main business divisions: Legend Global Logistics, " +
                    "leading the global transportation of bulk liquids, dry commodities, perishable products, and oversized cargos; and Legend Logistics Group, leading regional liner services, specialised " +
                    "logistics, break-bulk and Roll-On/Roll-Off (RORO) services, and heavy haulage and line haul.</p>" +
                    "<p class='obiz'>To distinguish the core business focuses of the two business divisions, we are excited to announce that Legend Logistics Group is rebranding as Regent Group, showcasing our unified strength in regional logistics management. </p>" +
                    "<p class='obiz'>This announcement marks a new and exciting era for Regent Group. Our new brand identity and aspiration symbolise a renewed focus on trust, innovation, and growth, as we serve our clients with cutting-edge specialised logistics that are personalised, smarter, and more efficient.</p>" +
                    "<p class='obiz'>Our client-led focus and on-the-ground expertise in the Bintan-Batam-Singapore liner services enable us to innovate across domestic and regional areas and offer a full spectrum of logistics unmatched by any other company. " +
                    "Uniting our diverse businesses under the Regent brand demonstrates our ability to reimagine logistics through transformative innovation while staying true to our company’s values and the level of personalised solutions customers expect. " +
                    "Regent will continue to offer unparalleled shipping flexibility and efficiency through our RORO and break-bulk service with daily connections between Singapore and Bintan, as well as Singapore and Batam.</p>" +
                    "<p class='obiz'>Our specialised logistics segment continues to offer four main branches of services: General Cargo Trucking, Dangerous Goods Trucking, Healthcare Logistics, and Automotive Logistics. Our integrated logistics solutions are meticulously " +
                    "designed to meet all regulatory requirements, ensuring the safe and secure handling of healthcare logistics such as pharmaceuticals, medical devices, and diagnostic samples. Our comprehensive range of automotive logistics solutions includes " +
                    "customs processing, authorised warehouses, and distribution services. Regent will soon be introducing a private yacht chartering service for up to 12 passengers for corporate bookings. LCL shipping services will also be part of our upcoming offerings in the near future.</p>" +
                    "<p class='obiz'>Regent Group will continue to build on its Australian legacy of a strong track record in the field of infrastructure logistics with a focus on Tier 1 projects. We will continue to provide safe transportation and storage solutions with our fleet of specialised trucks, " +
                    "customised trailers, and modifiable purpose-built trailers to serve the unique logistics needs of our customers.</p>" +
                    "<p class='obiz'>We have also updated our registered and correspondence office address to 3 Harbourfront Place #04- 03/04, Harbourfront Tower Two, Singapore 099254. Please update your records accordingly to ensure all future correspondence reaches us promptly.</p>" +
                    "<p class='obiz'>Our new logo, colours, and font will be rolled out across all company materials and branding assets over time. Should you have any questions or require further information, please visit <a href='https://www.regentgroup.sg'>www.regentgroup.sg</a> " +
                    "or reach out to our team at corporate@regentgroup.sg. </p>" +
                    "<p class='obiz'>Once again, we would like to thank you for being a valued part of our journey for the last decade and we look forward to continuing our successful partnership with you as Regent.</p>" +
                    "<p class='obiz'>Warm regards,</p>" +
                    "<p class='obiz'>Eddie Leong<br>Chief Executive Officer<br>REGENT GROUP</p>" +
                    //"<div class='row'><div class='col-3'><img src='../Content/images/RegentVessel/EddieSign.png' style='width:80%;' class='responsive'></div></div><br>Managing Director<br>REGENT GROUP</p>" +
                    "<p></p>";
            }
            if (ID == "Mar1125")
            {
                contactDetails.IDNews = "Mar1125";
                contactDetails.NewsYear = "2025";
                contactDetails.NewsHeader = "Regent Group Pte Ltd Announces the Acquisition of Batamindo Shipping & Warehousing Pte Ltd";
                contactDetails.NewsDate = "11 March 2025";
                contactDetails.NewsIMGPath = "<img src='../Content/images/RegentVessel/Batamindo1.jpg' alt='' style='width: 40%;margin:auto;' class='mb-4'>";
                contactDetails.NewsText =
                    "<p class='obiz'>Regent Group Pte Ltd is pleased to announce the successful acquisition of Batamindo Shipping & Warehousing Pte Ltd (BSW). " +
                    "This strategic acquisition aligns with our long-term vision to transform BSW into a leading regional feeder operator, leveraging Indonesia’s rapid " +
                    "economic growth and increasing trade connectivity across Southeast Asia.</p>" +

                    "<p class='obiz fw-bold' style='font-size:25px'>Strategic Growth and Expansion</p>" +

                    "<p class='obiz'>With this acquisition, BSW will strengthen its position in the regional maritime and logistics sector, focusing on enhancing feeder services across key Indonesian and Southeast Asian ports. " +
                    "Indonesia, the largest economy in Southeast Asia and the eighth-largest globally by GDP, presents significant opportunities for growth in shipping, logistics, and supply chain integration.</p>" +
                    "<p class='obiz'>Backed by Regent Group and Gallant Venture Ltd, a member of Salim Group, we are committed to investing in fleet expansion, digitalization, and operational efficiencies to enhance BSW’s service offerings and strengthen its competitive edge.</p>" +

                    "<p class='obiz fw-bold' style='font-size:25px'>Leadership and Operational Plans</p>" +

                    "<p class='obiz'>To drive this transformation, a dedicated and experienced management team from Regent Group will lead BSW’s growth strategy. With deep expertise in shipping and logistics, they will ensure a seamless transition while accelerating expansion efforts. " +
                    "BSW will focus on strengthening regional feeder services to enhance trade connectivity, optimizing Indonesia-Southeast Asia shipping corridors to improve market integration, and investing in technology and operational efficiencies to elevate service delivery. " +
                    "Additionally, the company will develop customer-centric solutions to enhance supply chain reliability and meet evolving industry demands.</p>" +

                    "<p class='obiz fw-bold' style='font-size:25px'>Commitment to Our Partners and Customers</p>" +

                    "<p class='obiz'>At Regent Group, we remain dedicated to providing seamless, efficient, and sustainable shipping and warehousing solutions. The combined strengths of Regent Group and Gallant Venture, a member of Salim Group, " +
                    "will drive continued growth, innovation, and value creation for our customers and stakeholders.</p>";
            }

            return contactDetails;
        }
        public static List<ContactDetails> NewsList2()
        {
            List<ContactDetails> contactDetails = new List<ContactDetails>();
            //2018
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Jan1218",
                NewsYear = "2018",
                NewsHeader = "Legend expands to Australia",
                NewsDate = "12 January 2018",
                NewsIMGPath = "../Content/images/AllNews/N18/news9.webp",
                NewsText = "Legend is proud to announce its' latest footprint...",
            });

            //2019
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Dec1019",
                NewsYear = "2019",
                NewsHeader = "Private equity fund managed by ACA Investments Pte Ltd has invested into Legend Shipping Pte Ltd",
                NewsDate = "10 December 2019",
                NewsIMGPath = "../Content/images/AllNews/N19/ACAXLegend.png",
                NewsText = " Legend Shipping Pte Ltd and its subsidiaries...",
            });
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Sep2419",
                NewsYear = "2019",
                NewsHeader = "Legend takes delivery of Faymonville telemax trailers",
                NewsDate = "24 September 2019",
                NewsIMGPath = "../Content/images/AllNews/N19/news2.webp",
                NewsText = "Legend took delivery of 2 units brand new Faymonville...",
            });
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Apr19",
                NewsYear = "2019",
                NewsHeader = "Legend introduces specialised trucking services",
                NewsDate = "April 2019",
                NewsIMGPath = "../Content/images/AllNews/N19/news3.webp",
                NewsText = "Legend Shipping Group is pleased to announce...",
            });
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Dec2919",
                NewsYear = "2019",
                NewsHeader = "Change of company name",
                NewsDate = "29 December 2019",
                NewsIMGPath = "../Content/images/AllNews/N19/LegendGrouplogo.webp",
                NewsText = "Legend has developed itself to be one of Asia's leading...",
            });

            //2020
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Dec3020",
                NewsYear = "2020",
                NewsHeader = "Legend Carrier Group completes acquisition of IG Logistics Group",
                NewsDate = "30 December 2020",
                NewsIMGPath = "../Content/images/AllNews/N20/30dec2020.webp",
                NewsText = "Ig is a provider of logistics and marine services...",
            });
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Nov1320",
                NewsYear = "2020",
                NewsHeader = "Legend Logistics Group wins the SMEs Excellence Growth Award at the ASEAN Business Awards 2020",
                NewsDate = "13 November 2020",
                NewsIMGPath = "../Content/images/AllNews/N20/new13nov2020.webp",
                NewsText = " Legend Logistics has won the renowned SMEs Excellence...",
            });
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Oct0920",
                NewsYear = "2020",
                NewsHeader = "Legend Australia takes delivery of two brand new Scania trucks",
                NewsDate = "09 October 2020",
                NewsIMGPath = "../Content/images/AllNews/N20/Newscania.webp",
                NewsText = "Legend Australia added two brand new Scania trucks.....",
            });
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Aug1020",
                NewsYear = "2020",
                NewsHeader = "Legend Singapore celebrates National Day 2020",
                NewsDate = "10 August 2020",
                NewsIMGPath = "../Content/images/AllNews/N20/Singapore.webp",
                NewsText = "we will forge a brave new world and emerge stronger....",
            });
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Mar2520",
                NewsYear = "2020",
                NewsHeader = "Commencement of feeder (COC) service between Port Klang – Kuala Tanjung Port",
                NewsDate = "25 March 2020",
                NewsIMGPath = "../Content/images/AllNews/N20/FeederAnnouncement.webp",
                NewsText = "Legend Logistics Group is pleased to announce the commencement...",
            });
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Jul2320",
                NewsYear = "2020",
                NewsHeader = "Change of company name to Legend Logistics Limited",
                NewsDate = "23 July 2020",
                NewsIMGPath = "../Content/images/AllNews/N19/LegendGrouplogo.webp",
                NewsText = "With effective from 23rd July 2020, please be informed...",
            });

            //2021
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Sep2921",
                NewsYear = "2021",
                NewsHeader = "Legend launches its new direct feeder service between Pasir Gudang and Kuala Tanjung",
                NewsDate = "29 September 2021",
                NewsIMGPath = "../Content/images/AllNews/N21/Pasir.webp",
                NewsText = "Legend is proud to announce the opening...",
            });
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Jan1821",
                NewsYear = "2021",
                NewsHeader = "Legend Logistics Australia has been awarded a contract on AUD 6.7 Billion West Gate Tunnel Project",
                NewsDate = "18 January 2021",
                NewsIMGPath = "../Content/images/AllNews/N21/WGTPcopy.webp",
                NewsText = "WGTP is an AUD 6.7 billion project that links...",
            });
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Jul0521",
                NewsYear = "2021",
                NewsHeader = "Legend Logistics raises strategic investment from EDBI to Drive regional growth and digitalisation plans",
                NewsDate = "05 July 2021",
                NewsIMGPath = "../Content/images/AllNews/N21/Legend_and_EDBI_V2_modified1.webp",
                NewsText = "Legend was founded in 2012 as a Singapore-based...",
            });
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Mar2421",
                NewsYear = "2021",
                NewsHeader = "Legend Logistics Limited wins the Special Award for Internationalisation at the Enterprise 50",
                NewsDate = "24 March 2021",
                NewsIMGPath = "../Content/images/AllNews/N21/AwardImage.webp",
                NewsText = "Legend Logistics Limited is proud to announce...",
            });

            //2022
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Dec0922",
                NewsYear = "2022",
                NewsHeader = "Legend Logistics Australia opens Perth depot ahead of national expansion",
                NewsDate = "09 December 2022",
                NewsIMGPath = "../Content/images/AllNews/N22/Legendlogisticsopensperthdepot.webp",
                NewsText = "Legend Logistics Australia has taken a major step forward...",
            });
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Dec0222",
                NewsYear = "2022",
                NewsHeader = "Legend Logistics Group celebrates its 10th Anniversary Dinner & Dance",
                NewsDate = "02 December 2022",
                NewsIMGPath = "../Content/images/AllNews/N22/2000.webp",
                NewsText = "The Legend team had a momentous night by reminiscing back...",
            });
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Nov2922",
                NewsYear = "2022",
                NewsHeader = "Legend Logistics Australia has won two tenders on the AUD 15.8 billion North East Link Project",
                NewsDate = "29 November 2022",
                NewsIMGPath = "../Content/images/AllNews/N22/Tenders.webp",
                NewsText = "Legend Logistics Australia is excited to announce that ...",
            });
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Nov2422",
                NewsYear = "2022",
                NewsHeader = "Legend Logistics Group wins the Enterprise 50 Award 2022",
                NewsDate = "24 November 2022",
                NewsIMGPath = "../Content/images/AllNews/N22/e50OG.webp",
                NewsText = "Legend Logistics Group was honoured to receive...",
            });

            //2023
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Jun2823",
                NewsYear = "2023",
                NewsHeader = "Legend Logistics Group names as one of Singapore’s Best Managed Companies 2023",
                NewsDate = "28 June 2023",
                NewsIMGPath = "../Content/images/AllNews/N23/BestManaged1.jpeg",
                NewsText = "Legend Logistics Group is honored to be awarded as...",
            });
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Jun2123",
                NewsYear = "2023",
                NewsHeader = "PT Legend Marine Indonesia opens its new office in Batam",
                NewsDate = "21 June 2023",
                NewsIMGPath = "../Content/images/AllNews/N23/Batam.jpeg",
                NewsText = "On 21 June 2023, PT Legend Marine Indonesia...",
            });
            contactDetails.Add(new ContactDetails
            {
                IDNews = "May1323",
                NewsYear = "2023",
                NewsHeader = "Legend transports the first consignment of live broiler chickens from Bintan farm to Singapore Poultry Hub",
                NewsDate = "13 May 2023",
                NewsIMGPath = "../Content/images/AllNews/N23/MainPoultry.webp",
                NewsText = "After several months of meticulous planning...",
            });
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Feb2823",
                NewsYear = "2023",
                NewsHeader = "Legend completes the acquisition of Budgetcars Pte Ltd and its sister company, CFI Transport Pte Ltd",
                NewsDate = "28 February 2023",
                NewsIMGPath = "../Content/images/AllNews/N23/Budgetimage.webp",
                NewsText = "Legend Logistics Limited and its subsidiaries...",
            });
            contactDetails.Add(new ContactDetails
            {

                IDNews = "Jan1723",
                NewsYear = "2023",
                NewsHeader = "Legend Logistics Group recognises as one of Singapore’s Top 100 Fastest Growing Companies in 2023 ",
                NewsDate = "17 January 2023",
                NewsIMGPath = "../Content/images/AllNews/N19/LegendGrouplogo.webp",
                NewsText = "We are delighted to announce that Legend Logistics Limited...",
            });

            //2024
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Jul1024",
                NewsYear = "2024",
                NewsHeader = "Legend Logistics Group marks new era with new brand identity, Regent Group ",
                NewsDate = "10 July 2023",
                NewsIMGPath = "../Content/images/RegentVessel/RegentGroup.png",
                NewsText = "Legend Logistics Limited has provided comprehensive logistics solutions...",
            });
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Jun2823",
                NewsYear = "2024",
                NewsHeader = "Legend Logistics Group names as one of Singapore’s Best Managed Companies 2023",
                NewsDate = "28 June 2023",
                NewsIMGPath = "../Content/images/AllNews/N23/BestManaged1.jpeg",
                NewsText = "Legend Logistics Group is honored to be awarded as...",
            });
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Jun2123",
                NewsYear = "2024",
                NewsHeader = "PT Legend Marine Indonesia opens its new office in Batam",
                NewsDate = "21 June 2023",
                NewsIMGPath = "../Content/images/AllNews/N23/Batam.jpeg",
                NewsText = "On 21 June 2023, PT Legend Marine Indonesia...",
            });
            contactDetails.Add(new ContactDetails
            {
                IDNews = "May1323",
                NewsYear = "2024",
                NewsHeader = "Legend transports the first consignment of live broiler chickens from Bintan farm to Singapore Poultry Hub",
                NewsDate = "13 May 2023",
                NewsIMGPath = "../Content/images/AllNews/N23/MainPoultry.webp",
                NewsText = "After several months of meticulous planning...",
            });
            contactDetails.Add(new ContactDetails
            {
                IDNews = "Feb2823",
                NewsYear = "2024",
                NewsHeader = "Legend completes the acquisition of Budgetcars Pte Ltd and its sister company, CFI Transport Pte Ltd",
                NewsDate = "28 February 2023",
                NewsIMGPath = "../Content/images/AllNews/N23/Budgetimage.webp",
                NewsText = "Legend Logistics Limited and its subsidiaries...",
            });
            contactDetails.Add(new ContactDetails
            {

                IDNews = "Jan1723",
                NewsYear = "2024",
                NewsHeader = "Legend Logistics Group recognises as one of Singapore’s Top 100 Fastest Growing Companies in 2023 ",
                NewsDate = "17 January 2023",
                NewsIMGPath = "../Content/images/AllNews/N19/LegendGrouplogo.webp",
                NewsText = "We are delighted to announce that Legend Logistics Limited...",
            });

            return contactDetails;
        }
        public static List<SelectListItem> CareerList()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>()
            {
                new SelectListItem
                {
                    Text = "<div id=\"TrafficController\">" +
                    "<div class=\"row\"><div class=\"col-lg-12\">" +
                    "<h3 class=\"WhyChooseText\">Traffic Controller</h3><br>" +
                    "<div class=\"row\">" +
                    "<div class=\"col-lg-12 mb-4\">" +

                     "<div class=\"row\"><div class=\"col-lg-12\"><h5>Job Responsibilities</h5>" +
                    "<p class=\"obiz\" style=\"text-align:justify;\font-size:15px;\">This is a permanent position for the Traffic Controller with Regent Logistics Pte Ltd. The Traffic Controller will play a important role in coordinating and optimizing the movement of our land transport fleets to plan an efficient route planning and ensuring timely deliveries. He/She need to be able to communicate regular with our drivers, internal and external stakeholders.</p>"+
                    "<p class=\"obiz\" style=\"text-align:justify;\"><ol class=\"obiz careerorderedlist\" style=\"font-size:15px;\">" +
                    "<li>Responsible for planning, organizing and managing operations of the land logistics division</li>"+
                    "<li>Manage operational escalation, investigation and preventive action plan on job requirement</li>"+
                    "<li>Establish safety and security procedures</li>"+
                    "<li>Manage our fleet of vehicles and drivers (Prime Movers and Lorries) to achieve Key Performance Indicator (KPI)</li>"+
                    "<li>Deployment of vehicles and manpower to complete daily operations</li>"+
                    "<li>Adhere to statutory / company safety and health policies, procedures, and regulations</li>"+
                    "<li>Assist in all equipment maintenance</li>"+
                    "</ol></p></div>" +

                    "<div class=\"row\"><div class=\"col-lg-12\"><h5>Job Requirements</h5>" +
                    "<p class=\"obiz\" style=\"text-align:justify;\"><ol class=\"obiz careerorderedlist\" style=\"font-size:15px;\">" +
                    "<li>Relevant Experience in logistics, supply chain management, transportation or equivalent</li>"+
                    "<li>At Least two year of experience in the deployment of drivers for trucking/ loose cargo jobs.</li>"+
                    "<li>Strong understanding of land transportation regulations, routes, and logistical considerations in Singapore.</li>"+
                    "<li>Excellent communication and interpersonal skills, with the ability to interact effectively with all drivers </li>"+
                    "<li>Ability to work under pressure and prioritize tasks in a fast-paced environment.</li>"+
                    "<li>Detail-oriented with strong analytical and problem-solving abilities.</li>"+
                     "</ol></p></div><br><br>" +

                    "<div class=\"row\"><a href=\"mailto:careers@regentgroup.sg\" class=\"form-control carrierbtn btn btn-primary mb-3\"><h4 style=\"color: white;\">Apply Now</h4></a><br>" +
                    "<div class=\"row\" data-aos=\"fade-up\"><div class=\"col-lg-12\"><p class=\"WhyChooseText\" style=\"font-size:15px;font-weight: bold;\">General enquiries on career opportunities</p>" +
                    "<p class=\"obiz\"> You may reach us at:<br><a href=\"mailto:careers@regentgroup.sg\">careers@regentgroup.sg</a></p></div></div></div><br><br>",
                    Value = "TrafficController"
                },
                new SelectListItem
                {
                    Text = "<div id=\"CustomerServiceExecutive\">" +
                    "<div class=\"row\"><div class=\"col-lg-12\">" +
                    "<h3 class=\"WhyChooseText\">Accounts Executive</h3><br>" +
                    "<div class=\"row\">" +
                    "<div class=\"col-lg-12 mb-4\">" +
                    "<h5>Job Responsibilities</h5>" +
                    "<p class=\"obiz\" style=\"text-align:justify;\"><ol class=\"obiz careerorderedlist\" style=\"font-size:15px;\">" +
                    "<li>Handle full set of accounts for multiple entities</li>"+
                    "<li>Process and manage Accounts Receivable and Accounts Payable</li>"+
                    "<li>Assist to manage the day-to-day finance and accounting functions of the Company and its subsidiaries</li>"+
                    "<li>Record and manage transactions and events relating to inventory, accruals, prepayments, capital structure and finance costs</li>"+
                    "<li>Prepare and ensure the monthly financial and analytical reports are completed on a timely basis for review (income statement, balance sheet and the cash flow statement)</li>"+
                    "<li>Prepare and manage intercompany transactions, reconciliation and settlement</li>"+
                    "<li>Manage credit control and perform bank reconciliations and collection</li>"+
                    "<li>Responsible for quarterly GST Reporting</li>"+
                    "<li>Prepare required schedules and reports for yearly audit and tax purpose</li>"+
                    "<li>Liaise and follow-up with auditors on audit queries</li>"+
                    "<li>Ensure compliance with financial policies and procedures</li>"+
                    "<li>Other ad-hoc duties as requested by Reporting Officer</li>"+
                    "</ol></p></div>" +

                    "<div class=\"row\"><div class=\"col-lg-12\"><h5>Job Requirements</h5>" +
                    "<p class=\"obiz\" style=\"text-align:justify;\"><ol class=\"obiz careerorderedlist\" style=\"font-size:15px;\">" +
                    "<li>Bachelor's Degree in Accounting or related field and/Or other professional certifications</li>"+
                    "<li>Minimum 2 years of experience in accounting, preferably in similar industry</li>"+
                    "<li>Proficient in accounting software, Microsoft Office, and other relevant tools</li>"+

                    "</ol></p></div><br><br>" +

                    "<div class=\"row\"><a href=\"mailto:careers@regentgroup.sg\" class=\"form-control carrierbtn btn btn-primary mb-3\"><h4 style=\"color: white;\">Apply Now</h4></a><br>" +
                    "<div class=\"row\" data-aos=\"fade-up\"><div class=\"col-lg-12\"><p class=\"WhyChooseText\" style=\"font-size:15px;font-weight: bold;\">General enquiries on career opportunities</p>" +
                    "<p class=\"obiz\"> You may reach us at:<br><a href=\"mailto:careers@regentgroup.sg\">careers@regentgroup.sg</a></p></div></div></div>",
                    Value = "AccountsExecutive"
                },
            };
            return selectListItems;
        }
    }
}