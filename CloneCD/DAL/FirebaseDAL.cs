using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Google.Cloud.Firestore;
using Microsoft.Extensions.Configuration;
using static Google.Cloud.Firestore.V1.StructuredQuery.Types;

namespace CloneCD.DAL
{
	public class FirebaseDAL
	{
		private string filepath = "././wwwroot/clonecd-7b5d8-firebase-adminsdk-f07jp-9e4b491b33.json";
        string projectID = "clonecd-7b5d8";

        public FirebaseDAL()
		{
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
		}

        public FirestoreDb fireStoreDB
        {
            get { return FirestoreDb.Create(projectID); }
        }
    }
}

