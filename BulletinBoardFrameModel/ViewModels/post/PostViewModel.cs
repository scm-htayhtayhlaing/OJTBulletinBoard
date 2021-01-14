namespace BulletinBoardFrameModel.ViewModel.post
{
    /// <summary>
    ///     Post Getter and Setter class.
    /// </summary>
    public class PostViewModel
    {
        //Post Title
        public string title { get; set; }
        //Post Description
        public string description { get; set; }
        //Post Status (Public or Private)
        public int status { get; set; }
        //Created Usernmae
        public string name { get; set; }
        //Created Time
        public System.DateTime created_at { get; set; }
    }
}