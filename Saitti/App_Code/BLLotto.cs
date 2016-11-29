using System;
using System.Collections;

namespace JAMK.ICT {
	/// <summary>
	/// Summary description for Lotto.
	/// </summary>
	public class Lotto 	{
		private string myType = "Suomi";
		private int numberOfDraws, maxGenerated;
		private Random r2 = new
			Random(unchecked((int)DateTime.Now.Ticks)); 
		private Random r = new
			Random(~unchecked((int)DateTime.Now.Ticks)); 
		public string Tyyppi
		{
			get
			{
				return myType;
			}
			set
			{
				if (value == "Suomi" | value == "Viking")
				{
					myType = value;
					SetNumbers();
				}
			}
		}

		public Lotto()
		{
			myType = "Suomi";
			SetNumbers();
		}
    public Lotto(string tyyppi, int arvottavienLukum‰‰r‰, int arvottavienSuurin)
    {
      if ((myType != "") & (arvottavienLukum‰‰r‰ * arvottavienSuurin > 0) & (arvottavienLukum‰‰r‰ < arvottavienSuurin))
      {
        numberOfDraws = arvottavienLukum‰‰r‰;
        maxGenerated = arvottavienSuurin;
      }
    }
		private void SetNumbers()
		{		
			if (myType=="Suomi")
			{
				numberOfDraws=7;
				maxGenerated=39;
			}
			else if (myType =="Viking")
			{
				numberOfDraws=6;
				maxGenerated=48;
			}
      else if (myType == "Euro")
      {
        numberOfDraws = 8;
        maxGenerated = 80;
      }

		}
		public ArrayList Draw()
		{
			ArrayList a=new ArrayList();
			a.Clear();
			int number;
			for (int i=0; i<numberOfDraws ;i++)
			{	
				do
				{
					number=r.Next(0,maxGenerated) +1;
				}while (a.Contains(number));
				a.Add(number);
			}
			a.Sort();
			return a;
		}
	}
}