// const express = require('express');
// const mysql = require('mysql');

// const app = express();
// const port = 3000;

// const dbConnection = mysql.createConnection({
//   host: '192.168.1.240',
//   user: 'cad',
//   password: 'password',
//   database: 'a'
// });

// // Connect to the database
// dbConnection.connect((err) => {
//   if (err) {
//     console.error('Error connecting to database: ', err);
//     return;
//   }
//   console.log('Connected to database');
// });

// // Define your API endpoints
// app.get('/api/data', (req, res) => {
//   // Perform database query and send response
//   dbConnection.query('SELECT * FROM stdname', (error, results, fields) => {
//     if (error) {
//       console.error('Error querying database: ', error);
//       res.status(500).send('Error querying database');
//       return;
//     }
//     res.json(results);
//   });
// });

// // Start the server
// app.listen(port, () => {
//   console.log(`Server is running on http://localhost:${port}`);
// });




const express = require('express');
const mysql = require('mysql');


const app = express();
const cors = require('cors');
app.use(cors());
const port = 3000;


const dbConnection = mysql.createConnection({
  host: '192.168.1.240',
  user: 'cad',
  password: 'password',
  database: 'a'
});

// Connect to the database
dbConnection.connect((err) => {
  if (err) {
    console.error('Error connecting to database: ', err);
    return;
  }
  console.log('Connected to database');
});

// Middleware to parse JSON bodies
app.use(express.json());

// Define your API endpoint for registering data
app.post('/api/register', (req, res) => {
  const { name, age, address } = req.body;

  // Perform database insertion
  const sql = 'INSERT INTO sname(name, age, address) VALUES (?, ?, ?)';
  dbConnection.query(sql, [name, age, address], (error, results, fields) => {
    if (error) {
      console.error('Error inserting data into database: ', error);
      res.status(500).json({ error: 'Error inserting data into database' });
      return;
    }
    res.json({ success: true, message: 'Data inserted successfully' });
  });
});

// Start the server
app.listen(port, () => {
  console.log(`Server is running on http://localhost:${port}`);
});
