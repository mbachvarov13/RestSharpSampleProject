using Newtonsoft.Json;
using RestApiAutomationBL.Requests;
using RestApiAutomationBL.Responses;
using RestApiAutomationFramework.Utils;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiAutomationBL.Utils
{
    public class PostUtils
    {
        //Create new POST
        public static CreatePostValidResponse createPost(int id, string title, string author)
        {
            return RestClientUtil.Post<CreatePostValidResponse>("posts", createPostRequestBody(id, title, author)); ;
        }

        public static string createPostRequestBody(int id, string title, string author)
        {
            CreatePostValidRequest request = new CreatePostValidRequest();
            request.id = id;
            request.title = title;
            request.author = author;

            return JsonConvert.SerializeObject(request);
        }
    }
}