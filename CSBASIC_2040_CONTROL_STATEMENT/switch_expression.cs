int dayofweek = 1;

string s1 = "";

switch(dayofweek)
{
	case 0: s1 = "sun"; break;
	case 1: s1 = "mon"; break;
	case 2: s1 = "tue"; break;
	default : s1 = "unknown"; break;
}

string s2 = dayofweek switch 
			{
				0 => "sun",
				1 => "mon",
				2 => "tue",
				_ => "unknown"
			};
