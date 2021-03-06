using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class PostConstructorTest {

	[Test]
	public void TestStrengthIs100() {
		// Use the Assert class to test conditions.
		ShieldModel sm = new ShieldModel();
		int expectedStrength = 100;

		int result = sm.GetStrength ();

		Assert.AreEqual (expectedStrength, result);
	}
	[Test]
	public void TestRepairQuantity() { 
		ShieldModel sm = new ShieldModel ();
		int expectedQuantity = 10;
		int result = sm.RepairQuantity;
		Assert.AreEqual (expectedQuantity, result);
	}

	[Test]
	public void TestRepairThreshold() { 
		ShieldModel sm = new ShieldModel ();
		int expectedThreshold = 25;
		int result = sm.RepairableThreshold;
		Assert.AreEqual (expectedThreshold, result);
	}

	[Test]
	public void TestIsRepairable() { 
		ShieldModel sm = new ShieldModel ();
		bool isRepairable = sm.IsRepairable ();
		Assert.True (isRepairable);
	}
		
}
