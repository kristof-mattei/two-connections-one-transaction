// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    
    use tran = new TransactionScope () 


    let conn1 = new SqlConnection () 
    conn1.Open ()

    // do work

    conn1.Close ()


    let conn2 = new SqlConnection ()

    conn2.Open ()

    conn2.Close ()


    // work rolled back?
    // don't complete
    0