
using NUnit.Framework;
using System.Collections;

public class PostActionTest {
		[Test]
		public void TestAfterOneDamage() { 
			ShieldModel sm = new ShieldModel ();
			sm.TakeDamage (1);
		    int strength = sm.GetStrength();
			int checkStrength = strength;
			bool isRepairable = sm.IsRepairable ();
			Assert.True (isRepairable);
			Assert.That (strength == 99);
		}
		
	[Test]
	public void TestAfterTenDamage() { 
		ShieldModel sm = new ShieldModel ();
		sm.TakeDamage (10);
		int strength = sm.GetStrength ();
		int checkStrength = strength;
		bool isRepairable = sm.IsRepairable ();
		Assert.True (isRepairable);
		Assert.That (strength == 90);
	}

	[Test]
	public void TestAfterEightDamage() { 
		ShieldModel sm = new ShieldModel ();
		sm.TakeDamage (8 * 10);
		int strength = sm.GetStrength ();
		bool isRepairable = sm.IsRepairable ();
		Assert.False (isRepairable);
		Assert.That (strength == 20);
	}

	[Test]
	public void TestAfterNinetyDamage() { 
		ShieldModel sm = new ShieldModel ();
		sm.TakeDamage (90);
		int strength = sm.GetStrength ();
		bool isRepairable = sm.IsRepairable ();
		Assert.False (isRepairable);
		Assert.That (strength == 10);
	}

	[Test]
	public void TestAfterDamageAndTick() { 
		ShieldModel sm = new ShieldModel ();
		sm.TakeDamage (11);
		sm.Tick ();
		int strength = sm.GetStrength ();
		Assert.That (strength == 99);
	}

	}
