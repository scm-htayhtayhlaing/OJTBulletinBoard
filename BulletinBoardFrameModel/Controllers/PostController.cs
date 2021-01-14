using BulletinBoardFrameModel.Service.PostService;
using System.Web.Mvc;

namespace BulletinBoardFrameModel.PostControllers
{
    public class PostController : Controller
    {
        PostService postServices = new PostService();
        // GET: BulletinBoard
        /// <summary>
        ///     This is to get post list.
        /// </summary>
        /// <param name="search">Search keyword for Post</param>
        public ActionResult Post(string search)
        {
            var postList = postServices.ShowPost(search);
            return View("Post", postList);
        }
    }
}