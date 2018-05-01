using DecisionLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionLibTests
{
	[TestFixture]
	public class Class1Test {

		[Test]
		public void Class1ExistsTest() {
			// usually you'd set something special up using Class1 but... here goes as a terrible example...

			Class1 instance = new Class1();

			Assert.That(instance, Is.Not.Null);
		}

		[Test]
		public void Class1DoesntExistTest() {
			// these are terrible tests but hopefully they work as an example.

			Class1 instance = null;

			Assert.That(instance, Is.Null);

			// you can assert multiple things in a test... but there shoudl really be one test per.
			int count = 0;
			for (int i = 1; i <= 10; i++) {
				count += i;
			}

			Assert.That(count, Is.EqualTo((10 + 1) * 10 / 2));
		}
	}
}
