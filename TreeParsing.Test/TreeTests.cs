using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TreeParsing.Models.Domains;

namespace TreeParsing.Test
{
    public class TreeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Tree_Instance_Can_Be_Created()
        {
            // arrange
            // act
            var tree = new Tree(new List<int>{15, 10});
            
            // assert
            Assert.IsNotNull(tree);
        }

        [Test]
        public void Traverse_The_Constructed_Tree_Structure_Successfully()
        {
            // arrange
            var input = "15,10,22,4,12,18,24";
            var expectedResult = "4,12,10,18,24,22,15";
            var inputNumbers = input.Split(",").Select(int.Parse);
            var tree = new Tree(inputNumbers);
            
            // act
            var postOrderedNumbers = tree.Traverse();

            // assert
            var outputString = string.Join(",", postOrderedNumbers);
            Assert.AreEqual(outputString, expectedResult);
        }
    }
}
