using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite
{
    public class ReviewRepository : IReviewRepository
    {
        Dictionary<int, Review> allReviews = new Dictionary<int, Review>()
        {
            { 1, new Review() {Id = 1, Content = "this is content 1" } },
            { 2, new Review() {Id = 2, Content = "This is content for 2"} },
            { 3, new Review() {Id = 3, Content = "This is content for 3"} },
        };
    
        public Review FindById(int id)
        {
            return allReviews[id];
        }

        public List<Review> GetAll()
        {
            return allReviews.Values.ToList();
        }
    }
}
