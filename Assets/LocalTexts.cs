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
                    return "Sveikīīīīī";
                case LocalTexts.English:
                    return "Hello";
                default:
                    return "Hello";
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
                    return "Spēlēšanas stundas nedēļā";
                case LocalTexts.English:
                    return "Play time per week";
                default:
                    return "Play time per week";
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
                    return "E-pasts";
                case LocalTexts.English:
                    return "E-mail";
                default:
                    return "E-mail";
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
                    return new List<string>() { "---", "Man", "Woman", "Other" };
                default:
                    return new List<string>() { "---", "Man", "Woman", "Other" };
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
                        "12-20 hours a week",
                        "More than 20 hours a week"
                    };
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
