import React from 'react';
import { Link } from 'react-router-dom';
import './Navigation.css';

function Navigation() {
    return (
        <nav>
            <ul>
                <li><Link to="/">Home</Link></li>
                <li><Link to="/geschichte">Unternehmensgeschichte</Link></li>
                <li><Link to="/dienstleistungen">Dienstleistungen</Link></li>
                <li><Link to="/kontakt">Kontakt</Link></li>
                <li><Link to="/feedback">Feedback</Link></li>
            </ul>
        </nav>
    );
}

export default Navigation;