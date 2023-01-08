using System;
using System.Collections.Generic;
using Google.Cloud.Firestore;
using CloneCD.Models;
using System.Threading.Tasks;

namespace CloneCD.DAL
{
	public class UsersDAL
	{
		FirebaseDAL fb = new FirebaseDAL();
		Users user = new Users();
		public UsersDAL()
		{

		}

		public async void addUsers()
		{
			DocumentReference docRef = fb.fireStoreDB.Collection("users").Document("alovelace");
			Dictionary<string, object> user = new Dictionary<string, object>
			{
				{"first","ada" },
				{"middle","cool"},
				{"last", "here" }
			};
			await docRef.SetAsync(user);
		}

		public async Task<Dictionary<string, object>> listUsers()
		{
            CollectionReference userRef = fb.fireStoreDB.Collection("users");
			QuerySnapshot snapshot = await userRef.GetSnapshotAsync();
			Dictionary<string, object> docDict = new Dictionary<string, object>();
            foreach (DocumentSnapshot doc in snapshot.Documents)
			{
				docDict = doc.ToDictionary();
				Console.WriteLine(docDict["middle"]);
			}
			return docDict;
        }
	}
}

