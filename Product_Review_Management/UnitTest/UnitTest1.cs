using NUnit.Framework;
using Product_Review_Management;
using System.Collections.Generic;

namespace Product_Review_Management
{
    public class Tests
    {
        ProductReviewManagement product;
        List<ProductReview> ProductReviewsList;

        [SetUp]
        public void Setup()
        {
            product = new ProductReviewManagement();
            ProductReviewsList = new List<ProductReview>();
        }
        /// <summary>
        /// TC 1: Adding a Productreview details in list and returns the count
        /// </summary>
        [Test]
        public void ReturnCountofListCreated()
        {
            int expected = 25;
            int actual = product.AddProductReview();
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC 2: Retrieve Top Three Records Whose Rating is High
        /// </summary>
        [Test]
        public void ForRetrieveTopThreeRecord()
        {
            int expected = 3;
            var actual = product.RetrieveTopThreeRating();
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC 3: Retrieve records from list based on productid and rating. 
        /// </summary>
        [Test]
        public void RetrieveRecordsBasedOnRatingAndProductID()
        {
            string expected = "7 3 3 15 7 ";
            string actual = product.RetrieveRecordsBasedOnRatingAndProductId();
            Assert.AreEqual(expected, actual);
        }
    }
}
