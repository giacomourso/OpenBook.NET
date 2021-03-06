﻿namespace OpenBook.Models.ApiResults.UserAdditionalData
{
    public class LastActivity : LocalizedResultBase
    {
        public Activity Activity { get; set; }
        public string GUID { get; set; }
        public bool IsCurrentUserFlagged { get; set; }
        public bool IsCurrentUserFollowing { get; set; }
        public bool IsCurrentUserLiked { get; set; }
        public bool IsSpam { get; set; }
        public string ItemType { get; set; }
        public Market Market { get; set; }
        public DetailedUser Owner { get; set; }
        public string PublishDate { get; set; }

    }
}
