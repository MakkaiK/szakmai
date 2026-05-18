import React from 'react'
import { Link } from 'react-router-dom';

export default function Card({ szallas, GetData }) {
    return (
        <Link to={`/szallas/${szallas.id}`}>
            <div className="card" style={{ width: '18rem', border: '1px solid black', margin: '10px', padding: '10px' }}>
                <div className="card-body">
                    <h5 className="card-title">{szallas.hostname}</h5>
                    <p className="card-title">{szallas.name}</p>
                    <p className="card-text">{szallas.location}</p>
                    <p className="card-text">{szallas.price}</p>
                    <p className="card-text">{szallas.minimum_nights}</p>
                </div>
            </div>
        </Link>
    )
}
