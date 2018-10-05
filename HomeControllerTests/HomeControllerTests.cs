using Microsoft.AspNetCore.Mvc;
using ReviewSite.Controllers;
using System;
using Xunit;



namespace ReviewSite.Tests
{
    public class ReviewsControllerTests
    {
        //IReviewRepository reviewRepo;
        //ReviewsController underTest;

        //public ReviewsControllerTests()
        //{
        //    reviewsRepo = Substitute.For<IReviewRepository>();
        //   // underTest = new ReviewsController(reviewsRepo);
        //}

        [Fact]
            public void Index_Returns_A_View()
            {
                var underTest = new ReviewsController();

                var result = underTest.Index();

                Assert.IsType<ViewResult>(result);
            }

        [Fact]
        public void Index_Gets_All_Reviews()
        {
            var reviewRepo = Substitute.For<IReviewRepository>();

            var underTest = new ReviewsController();
            
            var result = underTest.Index();
            reviewsRepo.Received().GetAll();
        }


    }
}
