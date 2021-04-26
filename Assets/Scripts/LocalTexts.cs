using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalTexts
{
    public static string Language = "en";

    public const string English = "en";

    public const string Latvian = "lv";

    public static string STRING_001
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return "Sveicināti! Es esmu Marija Isupova, Latvijas Universitātes Datorikas fakultātes maģistrantūras studente. Es veicu eksperimentu par telpas formas ietekmi uz navigācijas spējām, un šajā eksperimentā es arī aicinu Jūs piedalīties.\n\nEksperimenta mērķis ir atrast labirintā 3 paslēptus objektus un pēc tam atgriezties starta punktā. Pirms paša eksperimenta uzsākšanas notiks īsa apmācība, kuras gaitā Jūs tiksiet iepazīstināti ar visu nepieciešamo informāciju. Pats eksperiments neaizņems vairāk par 10 minūtēm.\n\nPēc eksperimenta beigām, lūdzu, aizpildiet īso anketu.";
                case LocalTexts.English:
                    return "Hello! I am Maria Isupova, a Master's student at the University of Latvia. I'm conducting the experiment regarding the effect of environment on spatial naviagations skills, and I ask you to take part in this experiment.\n\nThe goal of this experiment is to find 3 items in the maze and return to the starting point. In the beginning there will be a short tutorial, explaining all necessary information. The experiment itself shouldn't take more than 10 minutes.\n\nAfter the end of the experiment, please fill in the short questionnaire.";
                default:
                    return "Hello! I am Maria Isupova, Master's student at the University of Latvia. I'm conducting the experiment regarding the effect of environment on spatial naviagations skills, and I ask you to take part in this experiment.\n\nThe goal of this experiment is to find 3 items in the maze and return to the starting point. In the beginning there will be a short tutorial, explaining all necessary information. The experiment itself shouldn't take more than 10 minutes.\n\nAfter the end of the experiment, please fill in the short questionnaire.";
            }
        }
    }

    public static string STRING_002
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return "Valsts";
                case LocalTexts.English:
                    return "Country of residence";
                default:
                    return "Country of residence";
            }
        }
    }

    public static string STRING_003
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return "Dzimums";
                case LocalTexts.English:
                    return "Gender";
                default:
                    return "Gender";
            }
        }
    }

    public static string STRING_004
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return "Vecums";
                case LocalTexts.English:
                    return "Age";
                default:
                    return "Age";
            }
        }
    }

    public static string STRING_005
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return "Cik stundas nedēļā Jūs spēlējat videospēles (arī uz mobilā telefona)";
                case LocalTexts.English:
                    return "Hours per week playing videogames (including mobile games)";
                default:
                    return "Hours per week playing videogames (including mobile games)";
            }
        }
    }

    public static string STRING_006
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return "E-pasts (nav obligāti)";
                case LocalTexts.English:
                    return "E-mail (optional)";
                default:
                    return "E-mail (optional)";
            }
        }
    }

    public static string STRING_007
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return "Augstākais iegūtais izglītības līmenis";
                case LocalTexts.English:
                    return "Highest level of education completed";
                default:
                    return "Highest level of education completed";
            }
        }
    }

    public static string STRING_008
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return "Apsveicu, Jūs veiksmīgi izpildījāt uzdevumu! Lai pabeigtu eksperimentu, atbildiet, lūdzu, uz dažiem jautājumiem. Ja vēlaties, varat atstāt savu e-pasta adresi, lai saņemtu pētījuma rezultātus.";
                case LocalTexts.English:
                    return "Congratulations, you have successfully finished the task! Please fill in the short questionnaire. If you wish, you can leave an e-mail address to receive the results of this experiment.";
                default:
                    return "Congratulations, you have successfully finished the task! Please fill in the short questionnaire. If you wish, you can leave an e-mail address to receive the results of this experiment.";
            }
        }
    }

    public static string STRING_009
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return "Cik bieži Jūs lietojat navigācijas ierīces (Google Maps, Waze utt.)?";
                case LocalTexts.English:
                    return "How often do you use navigation tools (Google Maps, Waze, etc.)?";
                default:
                    return "How often do you use navigation tools (Google Maps, Waze, etc.)?";
            }
        }
    }

    public static string STRING_010
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return "Vai Jums ir krāsu redzes traucējumi?";
                case LocalTexts.English:
                    return "Do you have color blindness?";
                default:
                    return "Do you have color blindness?";
            }
        }
    }

        public static string STRING_011
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return "Paldies par piedalīšanos! Eksperiments ir pabeigts. Varat aizvērt šo logu.";
                case LocalTexts.English:
                    return "Thank you for participation! The experiment is completed. You may close this window now.";
                default:
                    return "Thank you for participation! The experiment is completed. You may close this window now.";
            }
        }
    }

    public static string continueBtnText
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return "Turpināt";
                case LocalTexts.English:
                    return "Continue";
                default:
                    return "Continue";
            }
        }
    }

    public static string submitBtnText
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return "Iesniegt";
                case LocalTexts.English:
                    return "Submit";
                default:
                    return "Submit";
            }
        }
    }

    public static string errorText
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return "Lūdzu aizpildīt visas ailes!";
                case LocalTexts.English:
                    return "Please fill all fields!";
                default:
                    return "Please fill all fields!";
            }
        }
    }

    public static string closeBtnText
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return "Aizvērt";
                case LocalTexts.English:
                    return "Close";
                default:
                    return "Close";
            }
        }
    }

    public static List<string> gender_list
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return new List<string>() { "---", "Vīrietis", "Sieviete", "Cits" };
                case LocalTexts.English:
                    return new List<string>() { "---", "Male", "Female", "Other" };
                default:
                    return new List<string>() { "---", "Male", "Female", "Other" };
            }
        }
    }

    public static List<string> navigation_tools_list
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return new List<string>()
                    {
                        "---",
                        "Vairākas reizes nedēļā",
                        "Reizi nedēļā",
                        "Dažas reizes mēnesī",
                        "Reizi mēnesī",
                        "Reizi pusgadā",
                        "Retāk par reizi pusgadā",
                        "Nekad"
                    };
                case LocalTexts.English:
                    return new List<string>()
                    {
                        "---",
                        "Many times a week",
                        "Once a week",
                        "Few times a month",
                        "Once a month",
                        "Once every half-year ",
                        "Less often than once every half-year",
                        "Never"
                    };
                default:
                    return new List<string>()
                    {
                        "---",
                        "Many times a week",
                        "Once a week",
                        "Few times a month",
                        "Once a month",
                        "Once every half-year ",
                        "Less often than once every half-year",
                        "Never"
                    };
            }
        }
    }

    public static List<string> colorblindness_list
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return new List<string>() { "---", "Jā, ir", "Nē, nav", "Nezinu" };
                case LocalTexts.English:
                    return new List<string>() { "---", "Yes", "No", "I don't know" };
                default:
                    return new List<string>() { "---", "Yes", "No", "I don't know" };
            }
        }
    }

    public static List<string> play_hours_per_week_list
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return new List<string>()
                    {
                        "---",
                        "Vispār nespēlēju",
                        "Mazāk par 1 stundu nedēļā",
                        "1-2 stundas nedēļā",
                        "2-4 stundas nedēļā",
                        "4-7 stundas nedēļā",
                        "7-12 stundas nedēļā",
                        "12-20 stundas nedēļā",
                        "Vairāk par 20 stundām nedēļā"
                    };
                case LocalTexts.English:
                    return new List<string>()
                    {
                        "---",
                        "None",
                        "Less than 1 hour a week",
                        "1-2 hours a week",
                        "2-4 hours a week",
                        "4-7 hours a week",
                        "7-12 hours a week",
                        "12-20 hours a week",
                        "More than 20 hours a week"
                    };
                default:
                    return new List<string>()
                    {
                        "---",
                        "None",
                        "Less than 1 hour a week",
                        "1-2 hours a week",
                        "2-4 hours a week",
                        "4-7 hours a week",
                        "7-12 hours a week",
                        "12-20 hours a week",
                        "More than 20 hours a week"
                    };
            }
        }
    }

    public static List<string> education_list
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return new List<string>()
                    {
                        "---",
                        "Pamatizglītība vai zemāk",
                        "Vidējā izglītība",
                        "Nepabeigta augstākā izglītība",
                        "Arodizglītība vai profesionālā vidējā izglītība",
                        "Bakalaura grāds",
                        "Maģistra grāds",
                        "Doktora grāds",
                        "2. līmeņa augstākā profesionālā izglītība"
                    };
                case LocalTexts.English:
                    return new List<string>()
                    {
                        "---",
                        "Less than high school",
                        "High school graduate",
                        "Some college credit, no degree",
                        "Technical or occupational certificate",
                        "Bachelor’s degree",
                        "Master’s degree",
                        "Doctorate",
                        "Professional degree"
                    };
                default:
                    return new List<string>()
                    {
                        "---",
                        "Less than high school",
                        "High school graduate",
                        "Some college credit, no degree",
                        "Technical or occupational certificate",
                        "Bachelor’s degree",
                        "Master’s degree",
                        "Doctorate",
                        "Professional degree"
                    };
            }
        }
    }

    public static List<string> itemsRemaining
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return new List<string>() { "3/3 objekti palikuši", "2/3 objekti palikuši", "1/3 objekts palicis" };
                case LocalTexts.English:
                    return new List<string>() { "3/3 items remaining", "2/3 items remaining", "1/3 items remaining" };
                default:
                    return new List<string>() { "3/3 items remaining", "2/3 items remaining", "1/3 items remaining" };
            }
        }
    }

    public static string UI_MoveMouseText
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return "Paskaties apkārt, izmantojot peli.";
                case LocalTexts.English:
                    return "Look around by moving the mouse.";
                default:
                    return "Look around by moving the mouse.";
            }
        }
    }

    public static string UI_MoveAroundText
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return "Izmantojiet ↑ ← ↓ → pogas vai W A S D pogas (uz priekšu, pa labi, atpakaļ, pa kreisi atbilstoši), lai pārvietotos.";
                case LocalTexts.English:
                    return "Use ↑ ← ↓ → arrow keys or W A S D keys (forward, right, backward and left accordingly) to move around.";
                default:
                    return "Use ↑ ← ↓ → arrow keys or W A S D keys (forward, right, backward and left accordingly) to move around.";
            }
        }
    }

    public static string UI_TouchText
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return "Eksperimenta gaitā būs nepieciešams labirintā atrast 3 objektus un pieskarties tiem. Pamēģiniet pieskarties vienam no objektiem.";
                case LocalTexts.English:
                    return "During the experiment you would need to collect 3 items in the maze and touch them. Try to touch one of the objects in this room.";
                default:
                    return "During the experiment you would need to collect 3 items in the maze and touch them. Try to touch one of the objects in this room.";
            }
        }
    }

    public static string UI_CollectAllText
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return "Ļoti labi! Tagad pieskarieties visiem 3 objektiem šajā telpā.";
                case LocalTexts.English:
                    return "Good! Now touch all 3 objects in this room.";
                default:
                    return "Good! Now touch all 3 objects in this room.";
            }
        }
    }

    public static string UI_TutorialFinishedText
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return "Apmācība ir pabeigta! Eksperiments sāksies tajā brīdī, kad iziesiet ārā pa durvīm. Atcerieties, ka mērķis ir atrast labirintā visus 3 objektus un atgriezties atpakaļ. Laiks nav ierobežots.";
                case LocalTexts.English:
                    return "The tutorial is finished! The experiment will begin in the moment you go out the door. Remember that the goal is to collect 3 objects in this maze and to return back. There is no time limit.";
                default:
                    return "The tutorial is finished! The experiment will begin in the moment you go out the door. Remember that the goal is to collect 3 objects in this maze and to return back. There is no time limit.";
            }
        }
    }

    public static string UI_ReturnBackText
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return "Visi 3 objekti ir atrasti! Tagad jāatgriežas starta punktā.";
                case LocalTexts.English:
                    return "All objects are found! Now return to the starting point.";
                default:
                    return "All objects are found! Now return to the starting point.";
            }
        }
    }

    public static List<string> country_list
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return new List<string>()
                    {
                        "Latvija",
                        "Afganistāna",
                        "Albānija",
                        "Alžīrija",
                        "Andora",
                        "Angola",
                        "Antigva",
                        "Apvienotā Karaliste",
                        "Apvienotie Arābu Emirāti",
                        "Argentīna",
                        "Armēnija",
                        "Aruba",
                        "ASV",
                        "Austrālija",
                        "Austrija",
                        "Austrumtimora",
                        "Azerbaidžāna",
                        "Ālandu",
                        "Bahamu",
                        "Bahreina",
                        "Bangladeša",
                        "Barbadosa",
                        "Baltkrievija",
                        "Beļģija",
                        "Beliza",
                        "Benina",
                        "Bermudu",
                        "Birma",
                        "Bolīvija",
                        "Bosnija",
                        "Botsvāna",
                        "Brazīlija",
                        "Bruneja",
                        "Bulgārija",
                        "Burkinafaso",
                        "Burundi",
                        "Butāna",
                        "Centrālāfrikas Republika",
                        "Čada",
                        "Čehija",
                        "Čīle",
                        "Dānija",
                        "Dienvidāfrika",
                        "Dienviddžordžija",
                        "Dienvidkoreja",
                        "Dienvidsudāna",
                        "Dominika",
                        "Dominikāna",
                        "Džērsija",
                        "Džibutija",
                        "Ēģipte",
                        "Ekvadora",
                        "Ekvatoriālā Gvineja",
                        "Eritreja",
                        "Etiopija",
                        "Fidži",
                        "Filipīnas",
                        "Francija",
                        "Gabona",
                        "Gajāna",
                        "Gambija",
                        "Gana",
                        "Gērnsija",
                        "Gibraltārs",
                        "Grenāda",
                        "Grenlande",
                        "Grieķija",
                        "Gruzija",
                        "Guama",
                        "Gvadelupa",
                        "Gvatemala",
                        "Gvineja",
                        "Gvineja-Bisava",
                        "Haiti",
                        "Hondurasa",
                        "Honkonga",
                        "Horvātija",
                        "Igaunija",
                        "Indija",
                        "Indonēzija",
                        "Irāka",
                        "Irāna",
                        "Īrija",
                        "Islande",
                        "Itālija",
                        "Izraēla",
                        "Jamaika",
                        "Japāna",
                        "Jaunzēlande",
                        "Jemena",
                        "Jordānija",
                        "Kaboverde",
                        "Kambodža",
                        "Kamerūna",
                        "Kanāda",
                        "Katara",
                        "Kazahstāna",
                        "Kenija",
                        "Kipra",
                        "Kirasao",
                        "Kirgizstāna",
                        "Kiribati",
                        "Klipertona",
                        "Kolumbija",
                        "Komoru",
                        "Kongo",
                        "Kostarika",
                        "Kotdivuāra",
                        "Krievija",
                        "Kuba",
                        "Kuka",
                        "Kuveita",
                        "Ķīna",
                        "Laosa",
                        "Lesoto",
                        "Libāna",
                        "Libērija",
                        "Lībija",
                        "Lietuva",
                        "Lihtenšteina",
                        "Luksemburga",
                        "Maķedonija",
                        "Madagaskara",
                        "Majota",
                        "Makao",
                        "Malaizija",
                        "Malāvija",
                        "Maldīvija",
                        "Mali",
                        "Malta",
                        "Maroka",
                        "Māršala",
                        "Martinika",
                        "Mauritānija",
                        "Meksika",
                        "Melnkalne",
                        "Mikronēzija",
                        "Mjanma/Birma",
                        "Moldova",
                        "Monako",
                        "Mongolija",
                        "Montserrata",
                        "Mozambika",
                        "Namībija",
                        "Nauru",
                        "Nepāla",
                        "Nīderlande",
                        "Nigēra",
                        "Nigērija",
                        "Nikaragva",
                        "Niue",
                        "Norvēģija",
                        "Omāna",
                        "Pakistāna",
                        "Palau",
                        "Panama",
                        "Papua-Jaungvineja",
                        "Paragvaja",
                        "Peru",
                        "Pitkērna",
                        "Polija",
                        "Portugāle",
                        "Puertoriko",
                        "Reinjona",
                        "Rietumsahāra",
                        "Ruanda",
                        "Rumānija",
                        "Salvadora",
                        "Samoa",
                        "Sanmarīno",
                        "Santome",
                        "Saūda",
                        "Seišelas",
                        "Senegāla",
                        "Sentlūsija",
                        "Serbija",
                        "Singapūra",
                        "Sīrija",
                        "Sjerraleone",
                        "Slovākija",
                        "Slovēnija",
                        "Somālija",
                        "Somija",
                        "Spānija",
                        "Sudāna",
                        "Surinama",
                        "Svatini",
                        "Svazilenda",
                        "Šrilanka",
                        "Šveice",
                        "Tadžikistāna",
                        "Taivāna",
                        "Taizeme",
                        "Tanzānija",
                        "Togo",
                        "Tonga",
                        "Trinidāda",
                        "Tunisija",
                        "Turcija",
                        "Turkmenistāna",
                        "Tuvalu",
                        "Uganda",
                        "Ukraina",
                        "Ungārija",
                        "Urugvaja",
                        "Uzbekistāna",
                        "Vācija",
                        "Vanuatu",
                        "Vatikāns",
                        "Venecuēla",
                        "Vjetnama",
                        "Zālamana",
                        "Zambija",
                        "Ziemeļkoreja",
                        "Ziemeļmaķedonija",
                        "Zimbabve",
                        "Zviedrija"
                    };
                case LocalTexts.English:
                    return new List<string>()
                    {
                        "Latvia",
                        "Afghanistan",
                        "Albania",
                        "Algeria",
                        "American Samoa",
                        "Andorra",
                        "Angola",
                        "Anguilla",
                        "Antarctica",
                        "Antigua and Barbuda",
                        "Argentina",
                        "Armenia",
                        "Aruba",
                        "Australia",
                        "Austria",
                        "Azerbaijan",
                        "Bahamas",
                        "Bahrain",
                        "Bangladesh",
                        "Barbados",
                        "Belarus",
                        "Belgium",
                        "Belize",
                        "Benin",
                        "Bermuda",
                        "Bhutan",
                        "Bolivia",
                        "Bosnia and Herzegovina",
                        "Botswana",
                        "Bouvet Island",
                        "Brazil",
                        "British Indian Ocean Territory",
                        "Brunei Darussalam",
                        "Bulgaria",
                        "Burkina Faso",
                        "Burundi",
                        "Cambodia",
                        "Cameroon",
                        "Canada",
                        "Cape Verde",
                        "Cayman Islands",
                        "Central African Republic",
                        "Chad",
                        "Chile",
                        "China",
                        "Christmas Island",
                        "Cocos (Keeling) Islands",
                        "Colombia",
                        "Comoros",
                        "Congo",
                        "Congo, the Democratic Republic of the",
                        "Cook Islands",
                        "Costa Rica",
                        "Cote D'Ivoire",
                        "Croatia",
                        "Cuba",
                        "Cyprus",
                        "Czech Republic",
                        "Denmark",
                        "Djibouti",
                        "Dominica",
                        "Dominican Republic",
                        "Ecuador",
                        "Egypt",
                        "El Salvador",
                        "Equatorial Guinea",
                        "Eritrea",
                        "Estonia",
                        "Ethiopia",
                        "Falkland Islands (Malvinas)",
                        "Faroe Islands",
                        "Fiji",
                        "Finland",
                        "France",
                        "French Guiana",
                        "French Polynesia",
                        "French Southern Territories",
                        "Gabon",
                        "Gambia",
                        "Georgia",
                        "Germany",
                        "Ghana",
                        "Gibraltar",
                        "Greece",
                        "Greenland",
                        "Grenada",
                        "Guadeloupe",
                        "Guam",
                        "Guatemala",
                        "Guinea",
                        "Guinea-Bissau",
                        "Guyana",
                        "Haiti",
                        "Heard Island and Mcdonald Islands",
                        "Holy See (Vatican City State)",
                        "Honduras",
                        "Hong Kong",
                        "Hungary",
                        "Iceland",
                        "India",
                        "Indonesia",
                        "Iran, Islamic Republic of",
                        "Iraq",
                        "Ireland",
                        "Israel",
                        "Italy",
                        "Jamaica",
                        "Japan",
                        "Jordan",
                        "Kazakhstan",
                        "Kenya",
                        "Kiribati",
                        "Korea, Democratic People's Republic of",
                        "Korea, Republic of",
                        "Kuwait",
                        "Kyrgyzstan",
                        "Lao People's Democratic Republic",
                        "Lebanon",
                        "Lesotho",
                        "Liberia",
                        "Libyan Arab Jamahiriya",
                        "Liechtenstein",
                        "Lithuania",
                        "Luxembourg",
                        "Macao",
                        "Macedonia, the Former Yugoslav Republic of",
                        "Madagascar",
                        "Malawi",
                        "Malaysia",
                        "Maldives",
                        "Mali",
                        "Malta",
                        "Marshall Islands",
                        "Martinique",
                        "Mauritania",
                        "Mauritius",
                        "Mayotte",
                        "Mexico",
                        "Micronesia, Federated States of",
                        "Moldova, Republic of",
                        "Monaco",
                        "Mongolia",
                        "Montserrat",
                        "Morocco",
                        "Mozambique",
                        "Myanmar",
                        "Namibia",
                        "Nauru",
                        "Nepal",
                        "Netherlands",
                        "Netherlands Antilles",
                        "New Caledonia",
                        "New Zealand",
                        "Nicaragua",
                        "Niger",
                        "Nigeria",
                        "Niue",
                        "Norfolk Island",
                        "Northern Mariana Islands",
                        "Norway",
                        "Oman",
                        "Pakistan",
                        "Palau",
                        "Palestinian Territory, Occupied",
                        "Panama",
                        "Papua New Guinea",
                        "Paraguay",
                        "Peru",
                        "Philippines",
                        "Pitcairn",
                        "Poland",
                        "Portugal",
                        "Puerto Rico",
                        "Qatar",
                        "Reunion",
                        "Romania",
                        "Russian Federation",
                        "Rwanda",
                        "Saint Helena",
                        "Saint Kitts and Nevis",
                        "Saint Lucia",
                        "Saint Pierre and Miquelon",
                        "Saint Vincent and the Grenadines",
                        "Samoa",
                        "San Marino",
                        "Sao Tome and Principe",
                        "Saudi Arabia",
                        "Senegal",
                        "Serbia and Montenegro",
                        "Seychelles",
                        "Sierra Leone",
                        "Singapore",
                        "Slovakia",
                        "Slovenia",
                        "Solomon Islands",
                        "Somalia",
                        "South Africa",
                        "South Georgia and the South Sandwich Islands",
                        "Spain",
                        "Sri Lanka",
                        "Sudan",
                        "Suriname",
                        "Svalbard and Jan Mayen",
                        "Swaziland",
                        "Sweden",
                        "Switzerland",
                        "Syrian Arab Republic",
                        "Taiwan, Province of China",
                        "Tajikistan",
                        "Tanzania, United Republic of",
                        "Thailand",
                        "Timor-Leste",
                        "Togo",
                        "Tokelau",
                        "Tonga",
                        "Trinidad and Tobago",
                        "Tunisia",
                        "Turkey",
                        "Turkmenistan",
                        "Turks and Caicos Islands",
                        "Tuvalu",
                        "Uganda",
                        "Ukraine",
                        "United Arab Emirates",
                        "United Kingdom",
                        "United States",
                        "United States Minor Outlying Islands",
                        "Uruguay",
                        "Uzbekistan",
                        "Vanuatu",
                        "Venezuela",
                        "Viet Nam",
                        "Virgin Islands, British",
                        "Virgin Islands, US",
                        "Wallis and Futuna",
                        "Western Sahara",
                        "Yemen",
                        "Zambia",
                        "Zimbabwe"
                    };
                default:
                    return new List<string>() { };
            }
        }
    }
}
