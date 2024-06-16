import React from 'react';
import './Hero.css';

const Hero = () => {
    return (
        <section className="hero">
            <div className="hero-content">
                <i className="fas fa-gas-pump logo"></i>
                <h1 className="hero-heading">Welcome to the Gas Station Portal</h1>
                <p className="hero-subheading">Discover and contribute information about gas stations.</p>
                <div className="search-bar">
                    <input type="text" placeholder="Search gas stations..."/>
                    <button className="btn">Search</button>
                </div>
            </div>
        </section>
    );
}

export default Hero;
