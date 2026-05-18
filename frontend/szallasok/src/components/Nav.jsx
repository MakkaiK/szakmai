import React from 'react'
import { NavLink } from 'react-router-dom';

export default function Nav() {
  return (
    <div>
      <nav>
            <NavLink to="/">Szállások</NavLink>
            <NavLink to="/uj-szallas">Új szállás</NavLink>
      </nav>
    </div>
  )
}
