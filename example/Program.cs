using System;
using HighriseApi;
using HighriseApi.Models.Enums;

namespace HighriseApiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Username is your Highrise username (i.e. https://<username>.highrisehq.com)
            // If nothing else, it can be found under "Accounts & settings -> My info" in the 37signals ID badge
            const string username = "[USERNAME]";

            // Your authentication token can be found under "Accounts & settings -> My info -> API token"
            const string authenticationToken = "[TOKEN]";

            var api = new ApiRequest(username, authenticationToken);
            
            // Get all people your user has access to
            var people = api.PersonRequest.Get();


            Console.WriteLine("==People accessible==");
            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName);
                Console.WriteLine(person.Id);
                if (person.ContactData.EmailAddresses.Count != 0)
                    Console.WriteLine(person.ContactData.EmailAddresses[0].Address);
            }

            Console.WriteLine();
            Console.WriteLine("==Open Cases==");
            var cases = api.CaseRequest.Get(CaseStatus.Open);
            foreach (var cas in cases)
            {
                Console.WriteLine(cas.Name);
                Console.WriteLine(cas.Id);
            }

            Console.WriteLine();
            Console.WriteLine("==Companies==");
            var companies = api.CompanyRequest.Get();
            foreach (var com in companies)
            {
                Console.WriteLine(com.Name);
                Console.WriteLine(com.Id);
            }

            Console.WriteLine();
            Console.WriteLine("==deals==");
            var deals = api.DealRequest.Get();
            foreach (var del in deals)
            {
                Console.WriteLine(del.Name);
                Console.WriteLine(del.Id);
            }

            //==Notes API test Start==
            //Create note for company
            Console.WriteLine();
            Console.WriteLine("==Add Note for company==");
            var note = new Note { Body = "Note for Company for testing company through console app" };
            var newNote = api.NoteRequest.Create(SubjectType.Companies, 260722648, note);
            Console.WriteLine(newNote.Body);
            Console.WriteLine(newNote.Id);

            var compNoteToDelete = newNote.Id;

            //Create note for person
            Console.WriteLine();
            Console.WriteLine("==Add Note for person==");
            note = new Note { Body = "Note for Gem person through console app" };
            newNote = api.NoteRequest.Create(SubjectType.People, 257141812, note);
            Console.WriteLine(newNote.Body);
            Console.WriteLine(newNote.Id);

            var persNoteToGet = newNote.Id;

            //Create note for Case
            Console.WriteLine();
            Console.WriteLine("==Add Note for Case==");
            note = new Note { Body = "Note for RelatedToTestingUsers case through console app" };
            newNote = api.NoteRequest.Create(SubjectType.Kases, 1439491, note);
            Console.WriteLine(newNote.Body);
            Console.WriteLine(newNote.Id);

            var caseNoteToGetComments = newNote.Id;

            //Create note for deal
            Console.WriteLine();
            Console.WriteLine("==Add Note for deal==");
            note = new Note { Body = "Note for Imaginary deal  through console app" };
            newNote = api.NoteRequest.Create(SubjectType.Deals, 4850630, note);
            Console.WriteLine(newNote.Body);
            Console.WriteLine(newNote.Id);

            var dealNoteToUpdate = newNote.Id;

            //Get all notes for company
            Console.WriteLine();
            Console.WriteLine("==Get Notes for Company for testing==");
            var notesCompany = api.NoteRequest.Get(SubjectType.Companies, 260722648);
            foreach (var nc in notesCompany)
            {
                Console.WriteLine(nc.Body);
                Console.WriteLine(nc.Id);
            }

            //Get all notes for person
            Console.WriteLine();
            Console.WriteLine("==Get Notes for Gem person==");
            var notesPers = api.NoteRequest.Get(SubjectType.People, 257141812);
            foreach (var np in notesPers)
            {
                Console.WriteLine(np.Body);
                Console.WriteLine(np.Id);
            }

            //Get all notes for Case
            Console.WriteLine();
            Console.WriteLine("==Get Notes for RelatedToTestingUsers case==");
            var notesCase = api.NoteRequest.Get(SubjectType.Kases, 1439491);
            foreach (var nc in notesCase)
            {
                Console.WriteLine(nc.Body);
                Console.WriteLine(nc.Id);
            }

            //Get all notes for Case
            Console.WriteLine();
            Console.WriteLine("==Get Notes for Imaginary deal==");
            var notesDeal = api.NoteRequest.Get(SubjectType.Deals, 4850630);
            foreach (var nd in notesDeal)
            {
                Console.WriteLine(nd.Body);
                Console.WriteLine(nd.Id);
            }


            //Delete last added note under company
            Console.WriteLine();
            Console.WriteLine("==Delete last note added to company==");
            var result = api.NoteRequest.Delete(compNoteToDelete);
            Console.WriteLine(result ? "success" : "false");

            //Get last note added to person
            var persNote = api.NoteRequest.Get(persNoteToGet);
            Console.WriteLine();
            Console.WriteLine("==Get last note added to person==");
            Console.WriteLine(persNote.Body);
            Console.WriteLine(persNote.Id);

            //Get comments of last case Note
            Console.WriteLine();
            Console.WriteLine("==Get comments of last case Note==");
            var comments = api.NoteRequest.GetComments(caseNoteToGetComments);
            foreach (var cmt in comments)
            {
                Console.WriteLine(cmt.Body);
                Console.WriteLine(cmt.Id);
            }


            //Update note of last deal Note 
            Console.WriteLine();
            Console.WriteLine("==Update note of last deal Note==");
            var updateTo = new Note { Id = dealNoteToUpdate, Body = "Updated Note through console App" };
            bool flag = api.NoteRequest.Update(updateTo);

            Console.WriteLine(flag ? "success" : "false");
            //==Notes API test End==

            //==Email API test Start==
            //Create Email for company
            Console.WriteLine();
            Console.WriteLine("==Add Email for company==");
            var email = new Email { Title= "subject of Company email through console app", Body = "Email Body for Company for testing company through console app" };
            var newEmail = api.EmailRequest.Create(SubjectType.Companies, 260722648, email);
            Console.WriteLine(newEmail.Title);
            Console.WriteLine(newEmail.Body);
            Console.WriteLine(newEmail.Id);

            var compEmailToDelete = newEmail.Id;

            //Create Email for person
            Console.WriteLine();
            Console.WriteLine("==Add Email for person==");
            email = new Email { Title = "subject of person email through console app",  Body = "Email Body for Gem person through console app" };
            newEmail = api.EmailRequest.Create(SubjectType.People, 257141812, email);
            Console.WriteLine(newEmail.Title);
            Console.WriteLine(newEmail.Body);
            Console.WriteLine(newEmail.Id);

            var persEmailToGet = newEmail.Id;

            //Create Email for Case
            Console.WriteLine();
            Console.WriteLine("==Add Email for Case==");
            email = new Email { Title = "subject of Case email through console app", Body = "Email Body for RelatedToTestingUsers case through console app" };
            newEmail = api.EmailRequest.Create(SubjectType.Kases, 1439491, email);
            Console.WriteLine(newEmail.Title);
            Console.WriteLine(newEmail.Body);
            Console.WriteLine(newEmail.Id);

            var caseEmailToGetComments = newEmail.Id;

            //Create Email for deal
            Console.WriteLine();
            Console.WriteLine("==Add Email for deal==");
            email = new Email { Title = "subject of deal email through console app", Body = "Email Body for Imaginary deal  through console app" };
            newEmail = api.EmailRequest.Create(SubjectType.Deals, 4850630, email);
            Console.WriteLine(newEmail.Title);
            Console.WriteLine(newEmail.Body);
            Console.WriteLine(newEmail.Id);

            var dealEmailToUpdate = newEmail.Id;

            //Get all Emails for company
            Console.WriteLine();
            Console.WriteLine("==Get Emails for Company for testing==");
            var emailsCompany = api.EmailRequest.Get(SubjectType.Companies, 260722648);
            foreach (var nc in emailsCompany)
            {
                Console.WriteLine(newEmail.Title);
                Console.WriteLine(nc.Body);
                Console.WriteLine(nc.Id);
            }

            //Get all emails for person
            Console.WriteLine();
            Console.WriteLine("==Get Emails for Gem person==");
            var emailsPers = api.EmailRequest.Get(SubjectType.People, 257141812);
            foreach (var np in emailsPers)
            {
                Console.WriteLine(newEmail.Title);
                Console.WriteLine(np.Body);
                Console.WriteLine(np.Id);
            }

            //Get all emails for Case
            Console.WriteLine();
            Console.WriteLine("==Get emails for RelatedToTestingUsers case==");
            var emailsCase = api.EmailRequest.Get(SubjectType.Kases, 1439491);
            foreach (var nc in emailsCase)
            {
                Console.WriteLine(newEmail.Title);
                Console.WriteLine(nc.Body);
                Console.WriteLine(nc.Id);
            }

            //Get all emails for Case
            Console.WriteLine();
            Console.WriteLine("==Get Emails for Imaginary deal==");
            var emailsDeal = api.EmailRequest.Get(SubjectType.Deals, 4850630);
            foreach (var nd in emailsDeal)
            {
                Console.WriteLine(newEmail.Title);
                Console.WriteLine(nd.Body);
                Console.WriteLine(nd.Id);
            }


            //Delete last added email under company
            Console.WriteLine();
            Console.WriteLine("==Delete last email added to company==");
            result = api.EmailRequest.Delete(compEmailToDelete);
            Console.WriteLine(result ? "success" : "false");

            //Get last email added to person
            var persEmail = api.EmailRequest.Get(persEmailToGet);
            Console.WriteLine();
            Console.WriteLine("==Get last Email added to person==");
            Console.WriteLine(newEmail.Title);
            Console.WriteLine(persEmail.Body);
            Console.WriteLine(persEmail.Id);

            //Get comments of last case Email
            Console.WriteLine();
            Console.WriteLine("==Get comments of last case Email==");
            comments = api.EmailRequest.GetComments(caseEmailToGetComments);
            foreach (var cmt in comments)
            {
                Console.WriteLine(cmt.Body);
                Console.WriteLine(cmt.Id);
            }


            //Update Email of last deal Email 
            Console.WriteLine();
            Console.WriteLine("==Update Email of last deal==");
            var updateToEmail = new Email { Id = dealEmailToUpdate, Title = "Updated subject of deal email through console app",  Body = "Updated Email body through console App" };
            flag = api.EmailRequest.Update(updateToEmail);

            Console.WriteLine(flag ? "success" : "false");
            //==Email API test End==


            Console.WriteLine();
            Console.WriteLine("==person with id 257141812==");
            var guy = api.PersonRequest.Get(257141812);
            Console.WriteLine(guy.FirstName);

            Console.WriteLine();
            Console.WriteLine("==Account name==");
            var account = api.AccountRequest.Get();
            Console.WriteLine(account.Name);
            Console.WriteLine();
            Console.WriteLine("==All Tasks==");
            var tasks = api.TaskRequest.Get(HighriseApi.Models.Enums.TaskStatus.All);
            foreach (var task in tasks)
            {
                //Console.WriteLine(task.SubjectName);
                Console.WriteLine(task.Body);
            }



            Console.ReadLine();
        }
    }
}
