using System;
using System.Text;

namespace StringHelper
{
public class MyStringHelper
{
	public static String MettreEnMajusculePrenom(String surnameToCrop)
	{
		String[] surname = surnameToCrop.Split('-');
		StringBuilder stringBuilder = new StringBuilder();

		for (Int32 i = 0; i < surname.Length; i++)
		{
			stringBuilder.Append(surname[i].Substring(0, 1).ToUpper() + surname[i].Substring(1));

			if (i < surname.Length - 1)
				stringBuilder.Append("-");
		}

		return stringBuilder.ToString();

	}
}
