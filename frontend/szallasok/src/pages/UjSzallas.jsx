import { React, useState, useEffect } from 'react'
import axios from 'axios';
import { useNavigate } from 'react-router-dom';

export default function UjSzallas() {
    const URL = "https://nodejs.sulla.hu/data";
    const [szallas, setSzallas] = useState();
    const navigate = useNavigate();

    function onSubmit(event) {
        event.preventDefault();

        const data = {
            name: event.target.name.value,
            hostname: event.target.hostname.value,
            location: event.target.location.value,
            price: event.target.price.value,
            minimum_nights: event.target.minimum_nights.value
        };

        axios.post(URL, data)
            .then((response) => {
                alert("Sikeres létrehozás!");
                navigate("/");
            })
            .catch((error) => {
                console.error(error);
            });
    };

    return (
        <form onSubmit={onSubmit}>
            <input type="text" name='name' placeholder='név' />
            <input type="text" name='hostname' placeholder='host név' />
            <input type="text" name='location' placeholder='hely' />
            <input type="number" name='price' placeholder='ár' />
            <input type="number" name='minimum_nights' placeholder='minimum éjszakák' />
            <button type="submit">Lérehozás</button>
        </form>
    )
}
