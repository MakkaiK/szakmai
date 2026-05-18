import { React, useState, useEffect } from 'react'
import axios from 'axios';
import Card from '../components/Card';

export default function ListSzallas() {
    const [szallasok, setSzallasok] = useState([]);

    const URL = "https://nodejs.sulla.hu/data";

    function GetData() {
        axios.get(URL)
            .then((response) => {
                setSzallasok(response.data);
            })
            .catch((error) => {
                console.error(error);
            });
    }

    useEffect(() => {
        GetData();
    }, []);

    return (
        <div className='d-flex flex-wrap'>
            {szallasok.map((szallas) => (
                <Card key={szallas.id} szallas={szallas} GetData={GetData} />
            ))}
        </div>
    )
}
