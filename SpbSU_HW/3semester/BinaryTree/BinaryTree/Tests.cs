﻿using System;
using NUnit.Framework;

namespace BinaryTree
{
	[TestFixture]
	public class Tests
	{
		/// <summary>
		/// BFS iterator test.
		/// </summary>
		[Test]
		public void ConvertToString_test1()
		{
			BinaryTree<int> binTree = new BinaryTree<int>();
			binTree.Add(3);
			binTree.Add(0);
			binTree.Add(-5);
			binTree.Add(6);
			binTree.Add(-1);
			binTree.Add(-3);
			binTree.Add(11);
			string actual = binTree.ConvertToString();
			string excepted = "3 0 6 -5 11 -1 -3 ";
			Assert.AreEqual(excepted, actual);
		}

		[Test]
		public void ConvertToString_test2()
		{
			BinaryTree<int> binTree = new BinaryTree<int>();
			binTree.Add(11);
			string actual = binTree.ConvertToString();
			string excepted = "11 ";
			Assert.AreEqual(excepted, actual);
		}

		/// <summary>
		/// Add method test.
		/// </summary>
		[Test]
		public void AddMethod_test1()
		{
			BinaryTree<int> binTree = new BinaryTree<int>();
			binTree.Add(3);
			string excepted = binTree.ConvertToString();
			string actual = "3 ";
			Assert.AreEqual(excepted, actual);
		}

		[Test]
		public void AddMethod_test2()
		{
			BinaryTree<int> binTree = new BinaryTree<int>();
			binTree.Add(3);
			binTree.Add(4);
			binTree.Add(2);
			string excepted = binTree.ConvertToString();
			string actual = "3 2 4 ";
			Assert.AreEqual(excepted, actual);
		}

		/// <summary>
		/// Remove method test.
		/// </summary>
		[Test]
		public void RemoveMethod_test1()
		{
			BinaryTree<int> binTree = new BinaryTree<int>();
			binTree.Add(3);
			binTree.Add(0);
			binTree.Add(-5);
			binTree.Add(6);
			binTree.Delete(3);
			string excepted = "6 0 -5 ";
			string actual = binTree.ConvertToString();
			Assert.AreEqual(excepted, actual);
		}

		[Test]
		public void RemoveMethod_test2()
		{
			BinaryTree<int> binTree = new BinaryTree<int>();
			binTree.Add(4);
			binTree.Add(12);
			binTree.Add(3);
			binTree.Delete(3);
			binTree.Delete(4);
			string excepted = "12 ";
			string actual = binTree.ConvertToString();
			Assert.AreEqual(excepted, actual);
		}

		[Test]
		public void Foreach_test()
		{
			BinaryTree<int> binTree = new BinaryTree<int>();
			binTree.Add(3);
			binTree.Add(1);
			binTree.Add(4);
			int sum = 0;
			foreach (int value in binTree)
			{
				sum += value;
			}
			Assert.AreEqual("8", sum.ToString());
		}
	}
}

