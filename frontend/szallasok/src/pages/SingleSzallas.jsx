import { React, useState, useEffect } from 'react'
import {Link} from 'react-router-dom';
import Card from '../components/Card';
import axios from 'axios';

import { useParams } from 'react-router-dom';

export default function SingleSzallas() {
    const [szallas, setSzallas] = useState();
    const { id } = useParams();
    const URL = "https://nodejs.sulla.hu/data/" + id;

    useEffect(() => {
        axios.get(URL)
            .then((response) => {
                setSzallas(response.data);
            })
            .catch((error) => {
                console.error(error);
            });
    }, []);

    if (!szallas) {
        return <div>Betöltés...</div>;
    }

    return (
        <div>
            <div className="card" style={{ width: '18rem', border: '1px solid black', margin: '10px', padding: '10px' }}>
                <div className="card-body">
                    <h5 className="card-title">{szallas.hostname}</h5>
                    <p className="card-title">{szallas.name}</p>
                    <p className="card-text">{szallas.location}</p>
                    <p className="card-text">{szallas.price}</p>
                    <p className="card-text">{szallas.minimum_nights}</p>
                </div>
                <Link to="/">
                    <i class="bi bi-caret-left-fill"></i>
                </Link>
            </div>
        </div>
    )
}
