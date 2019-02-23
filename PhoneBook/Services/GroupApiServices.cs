using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Phonebook.Models;
using Phonebook.Models.DataModels;

namespace PhoneBook.Services
{
    public interface IGroupApiService
    {
        Task<List<Group>> Getlist();
    }

    public class GroupApiServices:IGroupApiService
    {
        public async Task<List<Group>> Getlist()
        {
            HttpClient client = new HttpClient();

            string apiEndpoint = Properties.Settings.Default.ApiEndpoint;

            client.BaseAddress = new Uri("http://127.0.0.130");

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            List<Group> groups = new List<Group>();

            var response = await client.GetAsync("groups");

            if(response.IsSuccessStatusCode)
            {
                groups = await response.Content.ReadAsAsync<List<Group>>();
            }
            return groups;
        }
    }
}