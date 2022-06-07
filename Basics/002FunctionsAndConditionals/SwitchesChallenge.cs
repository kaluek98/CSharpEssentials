// The Expectation is that you write your own code based
// on what you have learned in the class, it can be what you want
// If you are havind trouble thinging of something, write conditionals
// with the topic of PowerUps, what happens if the powerUp is good or bad.

using System;
					
public class Program
{
	public PowerUps playerPower;
	public PowerLevel playerLevel;
	public void Main()
	{ 
		playerLevel = new PowerLevel();
		playerLevel.power = 6;
		playerPower = new PowerUps();
		playerPower.currentPowerUp = PowerUps.powerUp.item2;
		playerPower.CheckPowerUp();
		playerLevel.powerLevel();
		
			
	}
}

public class PowerLevel{
 
	public int power;
	public void powerLevel(){
		if(power >= 5)
		{Console.WriteLine("Max power reached!");
		}
		else{ Console.WriteLine("Keep searching for powerups!");
			
		}
	}
}
	

public class PowerUps {
	
	
	public enum powerUp{
		item1,
		item2,
		item3,
		item4
	}
	
	public powerUp currentPowerUp = powerUp.item3;
	
	public void CheckPowerUp() {
		switch (currentPowerUp) {
			case powerUp.item1:
				Console.WriteLine("You've got fire breath!");
				break;
			case powerUp.item2:
				Console.WriteLine("You've got ice breath!");
				break;
			case powerUp.item3:
				Console.WriteLine("You've got stone skin!");
				break;
			case powerUp.item4:
				Console.WriteLine("You've got sonic speed!");
				break;
			default:
				Console.WriteLine("You're weak, Find a power up!");
				break;
		}
	}
}
using System;

namespace kizzy
{
					
public class Program
{
	public static void Main(string[] args)
	{
		string[] dogs = {"Poodle", "German Sheppard", "Doxen", "French Bulldog", "Golden Retriever"};
		foreach (string g in dogs)
		{
		Console.WriteLine(g);
		}
	}
}
}

		
