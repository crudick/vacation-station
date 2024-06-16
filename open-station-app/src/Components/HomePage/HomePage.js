import React from 'react';
import './HomePage.css';
import Hero from './Hero/Hero';

const HomePage = () => {
    return (
        <div className="home-container">

            <main>
                <Hero />

                <section id="contributing" className="section contributing">
                    <h2>Contribute Data</h2>
                    <p>Help us keep our database up-to-date by contributing information about gas stations.</p>
                    <a href="#" className="btn">Contribute Now</a>
                </section>

                <section id="querying" className="section querying">
                    <h2>Query Data</h2>
                    <p>Search for gas stations based on location, amenities, and more.</p>
                    <a href="#" className="btn">Search Now</a>
                </section>
            </main>

            <footer>
                <p>&copy; 2024 Gas Station Portal. All rights reserved.</p>
            </footer>
        </div>
    );
}

export default HomePage;
