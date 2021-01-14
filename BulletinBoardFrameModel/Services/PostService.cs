using BulletinBoardFrameModel.DAO;
using BulletinBoardFrameModel.DAO.PostDAO;
using BulletinBoardFrameModel.Properties;
using BulletinBoardFrameModel.ViewModel.post;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace BulletinBoardFrameModel.Service.PostService
{
    /// <summary>
    ///     Service Class
    ///     Contains all method validing and connecting the Controller and DAO
    /// </summary>
    public class PostService
    {
        PostDAO postDAO = new PostDAO();
        /// <summary>
        ///     This is to show post list.
        /// </summary>
        /// <param name="search">Search keyword for Post</param>
        public IEnumerable<PostViewModel> ShowPost(string search)
        {
            // just sample for call constant
            Debug.WriteLine(Constant.APP_NAME);
            var postList = postDAO.getPostList(search);
            return postList;
        }
    }
}