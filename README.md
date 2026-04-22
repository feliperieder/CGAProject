# CGAProject

# Trabalho Prático – Técnicas Avançadas de Computação Gráfica

## Ray Tracing, Path Tracing e Iluminação Global na Unity (HDRP)

## Descrição do Projeto

Este projeto consiste na construção de uma cena interativa utilizando a **Unity com HDRP (High Definition Render Pipeline)**, com o objetivo de demonstrar, de forma visual e prática, conceitos avançados de iluminação computacional.

A cena foi projetada para evidenciar diferenças entre **renderização em tempo real** e **Path Tracing**, destacando fenômenos como:

* Iluminação direta e indireta
* Sombras
* Reflexão especular
* Refração/transparência
* Color bleeding (iluminação global)

---

## Tecnologias Utilizadas

* Unity (HDRP)
* DirectX 12 (DXR habilitado)
* Path Tracing nativo da HDRP
* Sistema de Input moderno (Input System)

---

## Funcionalidades Implementadas

### Controle de Luz Global (Directional Light)

Foram implementados atalhos para controlar a intensidade da luz principal da cena:

* **Tecla 1** → Intensidade máxima (dia)
* **Tecla 2** → Intensidade média
* **Tecla 3** → Intensidade zero (noite)
---

### Lanterna do Jogador (Spotlight)

O usuário possui uma lanterna acoplada à câmera:

**Tecla F** → Liga/desliga a lanterna

### 🎨 Controle de Cor da Lanterna

A lanterna pode ter sua cor alterada dinamicamente:

* **R** → Vermelho
* **G** → Verde
* **B** → Azul
* **E** → Branco

### Player Controlável

Foi implementado um controlador simples de jogador:

* Movimentação no espaço (WASD)
* Controle de câmera (mouse)
* Sistema de pulo (Espaço)

Permite explorar a cena livremente e observar os efeitos de iluminação de diferentes ângulos.

---

##  Efeitos de Iluminação Demonstrados

A cena foi construída para destacar os seguintes fenômenos:

### Iluminação Direta

* Múltiplas fontes de luz (Directional + Spotlight)

### Reflexão

* Superfícies metálicas e espelhadas
* Diferença entre Reflection Probes e Path Tracing

### Refração / Transparência

* Material de vidro configurado com refração
* Comportamento físico no Path Tracing

### Iluminação Indireta (Global Illumination)

* Aproximação via SSGI no tempo real
* Simulação física via Path Tracing

### Color Bleeding

* Visível principalmente no Path Tracing
* Luz refletida herdando cor das superfícies

---

