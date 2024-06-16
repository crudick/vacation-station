import logo from './logo.svg';
import './App.css';
import { Helmet } from 'react-helmet';
import Navbar from "./Components/Navbar/Navbar";
import HomePage from "./Components/HomePage/HomePage";

function App() {
  return (
    <div className="App">
        <Helmet>
            <meta charSet="utf-8"/>
            <title>Gas Station Portal</title>
            <link href="https://fonts.googleapis.com/css2?family=Exo:wght@400;700&display=swap" rel="stylesheet"/>
            <link rel="stylesheet"
                  href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css"
                  integrity="sha384-E+N7NNqOueL2+wJM0Fl9In8oqvgsNhNbo3ueLDDG08KGoHHKuL8WDvTxv+oDvmo8"
                  crossOrigin="anonymous"/>

        </Helmet>
        <Navbar/>
        <HomePage/>
    </div>
  );
}

export default App;
