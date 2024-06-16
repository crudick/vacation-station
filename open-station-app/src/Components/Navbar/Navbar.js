import React from 'react';
import './Navbar.css';

const Navbar = () => {
    return (
        <header>

            <nav className="navbar">
                <div className="logo">Gas Station Portal</div>
                <ul className="nav-links">
                    <li><a href="#">Home</a></li>
                    <li><a href="#contributing">Contribute Data</a></li>
                    <li><a href="#querying">Query Data</a></li>
                    <li><a href="#">About</a></li>
                    <li><a href="#">Contact</a></li>
                </ul>
            </nav>
        </header>
    );
}

export default Navbar;
