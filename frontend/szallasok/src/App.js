import './App.css';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Nav from './components/Nav';
import ListSzallas from './pages/ListSzallas';
import SingleSzallas from './pages/SingleSzallas';
import UjSzallas from './pages/UjSzallas';

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Nav />

        <Routes>
          <Route path="/" element={<ListSzallas/>} />
          <Route path="/szallas/:id" element={<SingleSzallas/>} />
          <Route path="/uj-szallas" element={<UjSzallas/>} />
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
