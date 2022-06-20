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
        /// <summary>
        /// TC 4: Retrive the count based on productID
        /// </summary>
        [Test]
        public void TestMethodForCountingProductId()
        {
            string expected = "3 1 2 2 2 2 4 1 2 1 1 1 3 ";
            string actual = product.CountingProductId();
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC 5: Retrieving the product ID and Review from list
        /// </summary>
        [Test]
        public void TestMethodForProductId()
        {
            string expected = "1 1 3 4 5 5 7 7 9 10 10 10 10 1 4 16 18 18 19 20 21 9 25 25 25 ";
            string actual = product.RetrieveOnlyProductIdAndReviews();
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC 6: Skip top Five records
        /// </summary>
        [Test]
        public void givenRecords_SkipTopFiveandReturn()
        {
            string expected = "10 10 25 7 7 9 20 25 25 4 5 5 19 21 1 1 3 16 18 18 ";
            string actual = product.SkipTop5Record();
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC 8: Adding a Productreview details in Data Table
        /// </summary>
        [Test]
        public void GivenCreateFunctionforDT_returnCountofListCreated()
        {
            int expected = 25;
            int actual = product.CreateDataTable();
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC 9: Retrieve the records whose column islike has true
        /// </summary>
        [Test]
        public void TestMethodForReturnsOnlyIsLikeFieldAsTrue()
        {
            string expected = "1 1 2 3 4 4 6 6 8 9 10 11 12 12 12 ";
            string actual = product.ReturnsOnlyIsLikeFieldAsTrue();
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC 10: Average of rating based on ProductID
        /// </summary>
        [Test]
        public void TestMethodForReturns_AverageofRating()
        {
            string expected = "2.3 1 3.5 2 3 4 4.2 1 1 2 3 2 3.3 ";
            string actual = product.AverageofRatingBasedonProductId();
            Assert.AreEqual(expected, actual);
        }


    }
}
