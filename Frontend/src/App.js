import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Navigation from './Components/Navigation';
import GeschichtePage from './Components/Geschichte';
import DienstleistungenPage from './Components/Dienstleistungen';
import KontaktPage from './Components/Kontakt';
import FeedbackPage from './Components/Feedback';
import LandingPage from './Components/LandingPage'; 


function App() {
    return (
        <Router>
            <div>
                <Navigation />
                <Routes>
                <Route path="/" element={<LandingPage />} /> {/* Landingpage als Startseite */}
                    <Route path="/geschichte" element={<GeschichtePage />} />
                    <Route path="/dienstleistungen" element={<DienstleistungenPage />} />
                    <Route path="/kontakt" element={<KontaktPage />} />
                    <Route path="/feedback" element={<FeedbackPage />} />
                </Routes>
            </div>
        </Router>
    );
}

export default App;