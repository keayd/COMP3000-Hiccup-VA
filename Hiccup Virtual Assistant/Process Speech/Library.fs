namespace ProcessInputs

// The F# file to process the user input into actions or responses that the VA uses.
open System
open System.Text.RegularExpressions

//type Interpreter(command:string) =
//    let matchedString = command
//    let (|Application|) =
//        let bool isApplication = true
//        None


module Interpreter = 

    let (|RegexContains|_|) pattern input =
             let matches = System.Text.RegularExpressions.Regex.Matches(input, pattern)
             if matches.Count > 0 then Some [ for m in matches -> m.Value ] 
             else None

    // Select a random response for the subject 'Hello'
    let hello_response () =
        let reply =
            let n = System.Random().Next(10)
            match n with
                | 0 -> "Hello to you too!"
                | 1 -> "Good Day!"
                | 2 -> "Hello, how are you today?"
                | 3 -> "Hi."
                | 4 -> "Welcome!"
                | 5 -> "How can I help?"
                | 6 -> "Salutations!"
                | 7 -> "How's it going?"
                | 8 -> "Sup."
                | 9 -> "Nice to meet you!"
                |_ -> "Yo yo friendly bro!"
        reply
            


    let goodbye_response () =
        let reply = 
            let n = System.Random().Next(10)
            match n with
                | 0 -> "See you later!"
                | 1 -> "Goodbye!"
                | 2 -> "Bye!"
                | 3 -> "See you."
                | 4 -> "I'll be waiting."
                | 5 -> "Thanks for a great chat!"
                | 6 -> "Au Revoir!"
                | 7 -> "Come back soon!"
                | 8 -> "It was lovely talking to you."
                | 9 -> "Please don't go..."
                |_ -> "Later Skater!"
        reply

    let application_response (query) =
        let reply =
            match query with
                | RegexContains "Open" query -> "application1"
                | RegexContains "Close" query -> "application2"
                | RegexContains "Search" query -> "application3"
        reply
            

    let question_response (query) =
        let reply =
             let questionURL = ("https://bing.com/search?q=" + query)
             questionURL
        reply
        
    let datetime_response (query) =
        let reply = 
            match query with
                | RegexContains "time" query -> "datetime1"
                | RegexContains "date" query -> "datetime2"
                | RegexContains "day" query -> "datetime3"
        reply

    let no_response () = 
        let reply =
            "none1"
        reply

    // The main response function, the first match with a key token returns the appropriate response.
//    let rec response (token:string) (str:string) = 
//           match token with
//           | hello
//               -> hello_response ()
//           | bye
//               -> goodbye_response ()
//           | personal
//               -> personal_response str
//           | question
//               -> question_response str
//           | negative 
//               -> negative_response str
//           | positive 
//               -> positive_response str
//           | maths
//               -> maths_response str
//          | "" 
//               -> none_response str
//           | None when (str.IndexOf(" ") > 0) 
//               -> response (str.Substring(0,str.IndexOf(" "))) 
//                          (str.Substring(str.IndexOf(" ")+1))
//           | None when (str.IndexOf(" ") < 0) 
//               -> response str ""
//           | None 
//               -> maths_response str
       
   
    // Create active recognizers to divide the input into different categories
    let match_input (query:string) =
    
        let (|Application|Hello|Goodbye|DateTime|None|) query =
                match query with
                    | RegexContains "Open" query| RegexContains "Close" query | RegexContains "Search" query 
                        -> Application //The Application recognizer is for opening or closing programs within the system - for example a web browser.
                    | "Hello" | "Hi" | "Nice to meet you" | "Sup" | "Good morning" | "Good afternoon" | "Good evening" 
                        -> Hello
                    |"Goodbye" | "See you later" | "Bye" | "Good night" 
                        -> Goodbye
                    | RegexContains "time" query| RegexContains "date" query| RegexContains "day" query
                        -> DateTime
                    | _ -> None

        let response =
            match query with
                | Application
                    -> application_response(query) //The Application recognizer is for opening or closing programs within the system - for example a web browser.
                |  Hello
                    -> hello_response()
                |  Goodbye 
                    -> goodbye_response()
                | DateTime
                    -> datetime_response(query)
                | _ -> no_response()
        response
            