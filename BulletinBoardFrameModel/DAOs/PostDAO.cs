﻿using BulletinBoardFrameModel.Models;
using BulletinBoardFrameModel.ViewModel.post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BulletinBoardFrameModel.DAO.PostDAO
{
    /// <summary>
    ///     DAO (Data Access Class)
    ///     contains all method that connected to the database
    /// </summary>
    /// 
    public class PostDAO
    {
        BulletinBoardEntities db = new BulletinBoardEntities();
        /// <summary>
        ///     This is to get all post and created user name from database.
        /// </summary>
        public IEnumerable<PostViewModel> getPosts()
        {
            var postList = (from post in db.posts
                            join user in db.users
                            on post.create_user_id equals user.id
                            select new
                            {
                                title = post.title,
                                description = post.description,
                                status = post.status,
                                name = user.name,
                                created_at = post.created_at
                            }).ToList()
                          .Select(postView => new PostViewModel()
                          {
                              title = postView.title,
                              description = postView.description,
                              status = postView.status,
                              name = postView.name,
                              created_at = postView.created_at
                          });
            return postList;
        }
        /// <summary>
        ///     This is to get post and created username from database by using keyword.
        /// </summary>
        /// <param name="search">Search keyword for Post</param>
        public IEnumerable<PostViewModel> getPostsByKeyword(string search)
        {
            var postList = (from post in db.posts
                            join user in db.users
                            on post.create_user_id equals user.id
                            where post.title.ToUpper().Contains(search.ToUpper())
                            select new
                            {
                                title = post.title,
                                description = post.description,
                                status = post.status,
                                name = user.name,
                                created_at = post.created_at
                            }).ToList()
                          .Select(postView => new PostViewModel()
                          {
                              title = postView.title,
                              description = postView.description,
                              status = postView.status,
                              name = postView.name,
                              created_at = postView.created_at
                          });
            return postList;
        }
        /// <summary>
        ///     This is to get post list from database.
        /// </summary>
        /// <param name="search">Search keyword for Post</param>
        public IEnumerable<PostViewModel> getPostList(string search)
        {
            if (search == null || search.Equals(""))
            {
                return getPosts();
            }
            return getPostsByKeyword(search);
        }
    }
}