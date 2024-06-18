import React, { useState } from 'react';

function Feedback() {
    const [name, setName] = useState('');
    const [email, setEmail] = useState('');
    const [message, setMessage] = useState('');

    const handleSubmit = async (e) => {
        e.preventDefault();

        const response = await fetch('https://localhost:7273/api/feedback', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ name, email, message })
        });

        if (response.ok) {
            console.log('Feedback submitted successfully');
        } else {
            console.error('Failed to submit feedback');
        }
    };

    return (
        <form onSubmit={handleSubmit}>
            <div>
                <label>Name:</label>
                <input type="text" value={name} onChange={(e) => setName(e.target.value)} />
            </div>
            <div>
                <label>Email:</label>
                <input type="email" value={email} onChange={(e) => setEmail(e.target.value)} />
            </div>
            <div>
                <label>Message:</label>
                <textarea value={message} onChange={(e) => setMessage(e.target.value)}></textarea>
            </div>
            <button type="submit">Submit</button>
        </form>
    );
}

export default Feedback;
