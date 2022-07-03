import React from "react";
import { Button } from "@mui/material";
import { Navbar } from "../components/Navbar/Navbar";

export default function App() {
  return (
    <div className="App">
      <Navbar />
      <Button variant="outlined">I am a button</Button>
    </div>
  );
}
